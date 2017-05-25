﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Utilities
{
    internal sealed class CustomContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            var propertyInfo = member as PropertyInfo;
            if (propertyInfo != null)
            {
                if (propertyInfo.PropertyType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IClean)))
                {
                    property.ShouldSerialize = o => o != null && ((IClean)propertyInfo.GetValue(o))?.Clean == false;
                }
                else
                {
                    var propertyName = propertyInfo.Name;
                    var backingFieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    var backingField = propertyInfo.DeclaringType.GetTypeInfo().DeclaredFields.FirstOrDefault(f => f.Name == backingFieldName && f.FieldType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IClean)));
                    if (backingField != null)
                    {
                        property.ShouldSerialize = o => o != null && ((IClean)backingField.GetValue(o))?.Clean == false;
                    }
                }
            }
            return property;
        }
    }

    internal static class JsonHelper
    {
        private static JsonSerializerSettings DefaultSettings { get; } = new JsonSerializerSettings
        {
            Formatting = Formatting.None,
            ContractResolver = new CustomContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(processDictionaryKeys: true, overrideSpecifiedNames: false)
            },
            Converters = new JsonConverter[] { new StringEnumConverter(true) }
        };

        public static T FromJson<T>(string json) => (T)FromJson(json, typeof(T));

        public static object FromJson(string json) => FromJson(json, null);

        public static object FromJson(string json, Type type) => JsonConvert.DeserializeObject(json, type, DefaultSettings);

        public static T FromJson<T>(TextReader reader) => (T)FromJson(reader, typeof(T));

        public static object FromJson(TextReader reader) => FromJson(reader, null);

        public static object FromJson(TextReader reader, Type type) => JsonSerializer.Create(DefaultSettings).Deserialize(reader, type);

        public static void PopulateFromJson(string json, object target) => JsonConvert.PopulateObject(json, target, DefaultSettings);

        public static void PopulateFromJson(TextReader reader, object target) => JsonSerializer.Create(DefaultSettings).Populate(reader, target);

        public static string ToJson<T>(this T value) => ToJson(value, typeof(T));

        public static string ToJson(object value) => ToJson(value, (Type)null);

        public static string ToJson(object value, Type type) => JsonConvert.SerializeObject(value, type, DefaultSettings);

        public static void ToJson<T>(T value, TextWriter writer) => ToJson(value, typeof(T), writer);

        public static void ToJson(object value, TextWriter writer) => ToJson(value, null, writer);

        public static void ToJson(object value, Type type, TextWriter writer) => JsonSerializer.Create(DefaultSettings).Serialize(writer, value, type);

        public static List<JToken> FindTokens(this JToken containerToken, string name)
        {
            var matches = new List<JToken>();
            FindTokens(containerToken, name, matches);
            return matches;
        }

        private static void FindTokens(JToken containerToken, string name, List<JToken> matches)
        {
            if (containerToken.Type == JTokenType.Object)
            {
                foreach (var child in containerToken.Children<JProperty>())
                {
                    if (child.Name == name)
                    {
                        matches.Add(child.Value);
                    }
                    FindTokens(child.Value, name, matches);
                }
            }
            else if (containerToken.Type == JTokenType.Array)
            {
                foreach (var child in containerToken.Children())
                {
                    FindTokens(child, name, matches);
                }
            }
        }
    }
}
