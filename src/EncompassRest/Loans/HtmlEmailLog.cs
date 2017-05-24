using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HtmlEmailLog
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _body;
        public string Body { get { return _body; } set { _body = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBody() => !_body.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _creator;
        public string Creator { get { return _creator; } set { _creator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreator() => !_creator.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<string> _recipient;
        public string Recipient { get { return _recipient; } set { _recipient = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecipient() => !_recipient.Clean;
        private Value<string> _sender;
        public string Sender { get { return _sender; } set { _sender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSender() => !_sender.Clean;
        private Value<string> _subject;
        public string Subject { get { return _subject; } set { _subject = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubject() => !_subject.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _body.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _creator.Clean
                    && _dateUtc.Clean
                    && _description.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _recipient.Clean
                    && _sender.Clean
                    && _subject.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _body; v1.Clean = value; _body = v1;
                var v2 = _commentList; v2.Clean = value; _commentList = v2;
                var v3 = _comments; v3.Clean = value; _comments = v3;
                var v4 = _creator; v4.Clean = value; _creator = v4;
                var v5 = _dateUtc; v5.Clean = value; _dateUtc = v5;
                var v6 = _description; v6.Clean = value; _description = v6;
                var v7 = _fileAttachmentsMigrated; v7.Clean = value; _fileAttachmentsMigrated = v7;
                var v8 = _guid; v8.Clean = value; _guid = v8;
                var v9 = _id; v9.Clean = value; _id = v9;
                var v10 = _isSystemSpecificIndicator; v10.Clean = value; _isSystemSpecificIndicator = v10;
                var v11 = _logRecordIndex; v11.Clean = value; _logRecordIndex = v11;
                var v12 = _recipient; v12.Clean = value; _recipient = v12;
                var v13 = _sender; v13.Clean = value; _sender = v13;
                var v14 = _subject; v14.Clean = value; _subject = v14;
                var v15 = _systemId; v15.Clean = value; _systemId = v15;
                _settingClean = 0;
            }
        }
    }
}