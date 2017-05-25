using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskLog : IClean
    {
        private Value<DateTime?> _addDate;
        public DateTime? AddDate { get { return _addDate; } set { _addDate = value; } }
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<string> _addedByUserId;
        public string AddedByUserId { get { return _addedByUserId; } set { _addedByUserId = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _completed;
        public bool? Completed { get { return _completed; } set { _completed = value; } }
        private Value<string> _completedBy;
        public string CompletedBy { get { return _completedBy; } set { _completedBy = value; } }
        private Value<string> _completedByUserId;
        public string CompletedByUserId { get { return _completedByUserId; } set { _completedByUserId = value; } }
        private Value<DateTime?> _completedDateUtc;
        public DateTime? CompletedDateUtc { get { return _completedDateUtc; } set { _completedDateUtc = value; } }
        private Value<int?> _contactCount;
        public int? ContactCount { get { return _contactCount; } set { _contactCount = value; } }
        private Value<List<MilestoneTaskContact>> _contacts;
        public List<MilestoneTaskContact> Contacts { get { return _contacts; } set { _contacts = value; } }
        private Value<string> _contactsXml;
        public string ContactsXml { get { return _contactsXml; } set { _contactsXml = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _daysToComplete;
        public int? DaysToComplete { get { return _daysToComplete; } set { _daysToComplete = value; } }
        private Value<int?> _daysToCompleteFromSetting;
        public int? DaysToCompleteFromSetting { get { return _daysToCompleteFromSetting; } set { _daysToCompleteFromSetting = value; } }
        private Value<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get { return _expectedDate; } set { _expectedDate = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isRequiredIndicator;
        public bool? IsRequiredIndicator { get { return _isRequiredIndicator; } set { _isRequiredIndicator = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<DateTime?> _milestoneTaskLogDateUtc;
        public DateTime? MilestoneTaskLogDateUtc { get { return _milestoneTaskLogDateUtc; } set { _milestoneTaskLogDateUtc = value; } }
        private Value<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _taskDescription;
        public string TaskDescription { get { return _taskDescription; } set { _taskDescription = value; } }
        private Value<string> _taskGuid;
        public string TaskGuid { get { return _taskGuid; } set { _taskGuid = value; } }
        private Value<string> _taskName;
        public string TaskName { get { return _taskName; } set { _taskName = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addDate.Clean
                    && _addedBy.Clean
                    && _addedByUserId.Clean
                    && _alerts.Clean
                    && _alertsXml.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _completed.Clean
                    && _completedBy.Clean
                    && _completedByUserId.Clean
                    && _completedDateUtc.Clean
                    && _contactCount.Clean
                    && _contacts.Clean
                    && _contactsXml.Clean
                    && _dateUtc.Clean
                    && _daysToComplete.Clean
                    && _daysToCompleteFromSetting.Clean
                    && _expectedDate.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isRequiredIndicator.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _milestoneTaskLogDateUtc.Clean
                    && _priority.Clean
                    && _stage.Clean
                    && _systemId.Clean
                    && _taskDescription.Clean
                    && _taskGuid.Clean
                    && _taskName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addDate; v0.Clean = value; _addDate = v0;
                var v1 = _addedBy; v1.Clean = value; _addedBy = v1;
                var v2 = _addedByUserId; v2.Clean = value; _addedByUserId = v2;
                var v3 = _alerts; v3.Clean = value; _alerts = v3;
                var v4 = _alertsXml; v4.Clean = value; _alertsXml = v4;
                var v5 = _commentList; v5.Clean = value; _commentList = v5;
                var v6 = _commentListXml; v6.Clean = value; _commentListXml = v6;
                var v7 = _comments; v7.Clean = value; _comments = v7;
                var v8 = _completed; v8.Clean = value; _completed = v8;
                var v9 = _completedBy; v9.Clean = value; _completedBy = v9;
                var v10 = _completedByUserId; v10.Clean = value; _completedByUserId = v10;
                var v11 = _completedDateUtc; v11.Clean = value; _completedDateUtc = v11;
                var v12 = _contactCount; v12.Clean = value; _contactCount = v12;
                var v13 = _contacts; v13.Clean = value; _contacts = v13;
                var v14 = _contactsXml; v14.Clean = value; _contactsXml = v14;
                var v15 = _dateUtc; v15.Clean = value; _dateUtc = v15;
                var v16 = _daysToComplete; v16.Clean = value; _daysToComplete = v16;
                var v17 = _daysToCompleteFromSetting; v17.Clean = value; _daysToCompleteFromSetting = v17;
                var v18 = _expectedDate; v18.Clean = value; _expectedDate = v18;
                var v19 = _fileAttachmentsMigrated; v19.Clean = value; _fileAttachmentsMigrated = v19;
                var v20 = _guid; v20.Clean = value; _guid = v20;
                var v21 = _id; v21.Clean = value; _id = v21;
                var v22 = _isRequiredIndicator; v22.Clean = value; _isRequiredIndicator = v22;
                var v23 = _isSystemSpecificIndicator; v23.Clean = value; _isSystemSpecificIndicator = v23;
                var v24 = _logRecordIndex; v24.Clean = value; _logRecordIndex = v24;
                var v25 = _milestoneTaskLogDateUtc; v25.Clean = value; _milestoneTaskLogDateUtc = v25;
                var v26 = _priority; v26.Clean = value; _priority = v26;
                var v27 = _stage; v27.Clean = value; _stage = v27;
                var v28 = _systemId; v28.Clean = value; _systemId = v28;
                var v29 = _taskDescription; v29.Clean = value; _taskDescription = v29;
                var v30 = _taskGuid; v30.Clean = value; _taskGuid = v30;
                var v31 = _taskName; v31.Clean = value; _taskName = v31;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}