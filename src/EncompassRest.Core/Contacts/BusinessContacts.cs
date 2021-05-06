﻿namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public interface IBusinessContacts : IApiObject
    {
    }

    internal sealed class BusinessContacts : ApiObject, IBusinessContacts
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}