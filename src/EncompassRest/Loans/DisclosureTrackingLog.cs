using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTrackingLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _borrowerName;
        public string BorrowerName { get { return _borrowerName; } set { _borrowerName = value; } }
        private Value<string> _borrowerPairId;
        public string BorrowerPairId { get { return _borrowerPairId; } set { _borrowerPairId = value; } }
        private Value<string> _coBorrowerName;
        public string CoBorrowerName { get { return _coBorrowerName; } set { _coBorrowerName = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _containGfe;
        public bool? ContainGfe { get { return _containGfe; } set { _containGfe = value; } }
        private Value<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get { return _containSafeHarbor; } set { _containSafeHarbor = value; } }
        private Value<bool?> _containTil;
        public bool? ContainTil { get { return _containTil; } set { _containTil = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _disclosedAPR;
        public string DisclosedAPR { get { return _disclosedAPR; } set { _disclosedAPR = value; } }
        private Value<string> _disclosedBy;
        public string DisclosedBy { get { return _disclosedBy; } set { _disclosedBy = value; } }
        private Value<string> _disclosedByFullName;
        public string DisclosedByFullName { get { return _disclosedByFullName; } set { _disclosedByFullName = value; } }
        private Value<string> _disclosedMethod;
        public string DisclosedMethod { get { return _disclosedMethod; } set { _disclosedMethod = value; } }
        private Value<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get { return _disclosureCreatedDttmUtc; } set { _disclosureCreatedDttmUtc = value; } }
        private Value<bool?> _eDisclosureApplicationPackageIndicator;
        public bool? EDisclosureApplicationPackageIndicator { get { return _eDisclosureApplicationPackageIndicator; } set { _eDisclosureApplicationPackageIndicator = value; } }
        private Value<bool?> _eDisclosureApprovalPackageIndicator;
        public bool? EDisclosureApprovalPackageIndicator { get { return _eDisclosureApprovalPackageIndicator; } set { _eDisclosureApprovalPackageIndicator = value; } }
        private Value<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get { return _eDisclosureBorrowerAcceptConsentDate; } set { _eDisclosureBorrowerAcceptConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowereSignedDate;
        public DateTime? EDisclosureBorrowereSignedDate { get { return _eDisclosureBorrowereSignedDate; } set { _eDisclosureBorrowereSignedDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        public DateTime? EDisclosureBorrowerRejectConsentDate { get { return _eDisclosureBorrowerRejectConsentDate; } set { _eDisclosureBorrowerRejectConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerViewConsentDate;
        public DateTime? EDisclosureBorrowerViewConsentDate { get { return _eDisclosureBorrowerViewConsentDate; } set { _eDisclosureBorrowerViewConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerViewMessageDate;
        public DateTime? EDisclosureBorrowerViewMessageDate { get { return _eDisclosureBorrowerViewMessageDate; } set { _eDisclosureBorrowerViewMessageDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerWetSignedDate;
        public DateTime? EDisclosureBorrowerWetSignedDate { get { return _eDisclosureBorrowerWetSignedDate; } set { _eDisclosureBorrowerWetSignedDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get { return _eDisclosureCoBorrowerAcceptConsentDate; } set { _eDisclosureCoBorrowerAcceptConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowereSignedDate;
        public DateTime? EDisclosureCoBorrowereSignedDate { get { return _eDisclosureCoBorrowereSignedDate; } set { _eDisclosureCoBorrowereSignedDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get { return _eDisclosureCoBorrowerRejectConsentDate; } set { _eDisclosureCoBorrowerRejectConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get { return _eDisclosureCoBorrowerViewConsentDate; } set { _eDisclosureCoBorrowerViewConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get { return _eDisclosureCoBorrowerViewMessageDate; } set { _eDisclosureCoBorrowerViewMessageDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get { return _eDisclosureCoBorrowerWebSignedDate; } set { _eDisclosureCoBorrowerWebSignedDate = value; } }
        private Value<string> _eDisclosureConsentPdf;
        public string EDisclosureConsentPdf { get { return _eDisclosureConsentPdf; } set { _eDisclosureConsentPdf = value; } }
        private Value<string> _eDisclosureDisclosedMessage;
        public string EDisclosureDisclosedMessage { get { return _eDisclosureDisclosedMessage; } set { _eDisclosureDisclosedMessage = value; } }
        private Value<bool?> _eDisclosureLockPackageIndicator;
        public bool? EDisclosureLockPackageIndicator { get { return _eDisclosureLockPackageIndicator; } set { _eDisclosureLockPackageIndicator = value; } }
        private Value<string> _eDisclosureManualFulfillmentComment;
        public string EDisclosureManualFulfillmentComment { get { return _eDisclosureManualFulfillmentComment; } set { _eDisclosureManualFulfillmentComment = value; } }
        private Value<DateTime?> _eDisclosureManualFulfillmentDate;
        public DateTime? EDisclosureManualFulfillmentDate { get { return _eDisclosureManualFulfillmentDate; } set { _eDisclosureManualFulfillmentDate = value; } }
        private Value<string> _eDisclosureManualFulfillmentMethod;
        public string EDisclosureManualFulfillmentMethod { get { return _eDisclosureManualFulfillmentMethod; } set { _eDisclosureManualFulfillmentMethod = value; } }
        private Value<string> _eDisclosureManuallyFulfilledBy;
        public string EDisclosureManuallyFulfilledBy { get { return _eDisclosureManuallyFulfilledBy; } set { _eDisclosureManuallyFulfilledBy = value; } }
        private Value<DateTime?> _eDisclosurePackageCreatedDate;
        public DateTime? EDisclosurePackageCreatedDate { get { return _eDisclosurePackageCreatedDate; } set { _eDisclosurePackageCreatedDate = value; } }
        private Value<string> _eDisclosurePackageId;
        public string EDisclosurePackageId { get { return _eDisclosurePackageId; } set { _eDisclosurePackageId = value; } }
        private Value<string> _eDisclosurePackageViewableFile;
        public string EDisclosurePackageViewableFile { get { return _eDisclosurePackageViewableFile; } set { _eDisclosurePackageViewableFile = value; } }
        private Value<bool?> _eDisclosureThreeDayPackageIndicator;
        public bool? EDisclosureThreeDayPackageIndicator { get { return _eDisclosureThreeDayPackageIndicator; } set { _eDisclosureThreeDayPackageIndicator = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _financeCharge;
        public string FinanceCharge { get { return _financeCharge; } set { _financeCharge = value; } }
        private Value<List<DisclosureForm>> _forms;
        public List<DisclosureForm> Forms { get { return _forms; } set { _forms = value; } }
        private Value<string> _formsXml;
        public string FormsXml { get { return _formsXml; } set { _formsXml = value; } }
        private Value<string> _fulfillmentOrderedBy;
        public string FulfillmentOrderedBy { get { return _fulfillmentOrderedBy; } set { _fulfillmentOrderedBy = value; } }
        private Value<string> _fullfillmentProcessedDate;
        public string FullfillmentProcessedDate { get { return _fullfillmentProcessedDate; } set { _fullfillmentProcessedDate = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _isDisclosed;
        public string IsDisclosed { get { return _isDisclosed; } set { _isDisclosed = value; } }
        private Value<string> _isDisclosedAprLocked;
        public string IsDisclosedAprLocked { get { return _isDisclosedAprLocked; } set { _isDisclosedAprLocked = value; } }
        private Value<string> _isDisclosedByLocked;
        public string IsDisclosedByLocked { get { return _isDisclosedByLocked; } set { _isDisclosedByLocked = value; } }
        private Value<string> _isDisclosedFinanceChargeLocked;
        public string IsDisclosedFinanceChargeLocked { get { return _isDisclosedFinanceChargeLocked; } set { _isDisclosedFinanceChargeLocked = value; } }
        private Value<string> _isDisclosedReceivedDateLocked;
        public string IsDisclosedReceivedDateLocked { get { return _isDisclosedReceivedDateLocked; } set { _isDisclosedReceivedDateLocked = value; } }
        private Value<string> _isLocked;
        public string IsLocked { get { return _isLocked; } set { _isLocked = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<bool?> _isWetSignedIndicator;
        public bool? IsWetSignedIndicator { get { return _isWetSignedIndicator; } set { _isWetSignedIndicator = value; } }
        private Value<string> _loanAmount;
        public string LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<string> _loanProgram;
        public string LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        private Value<string> _lockedDisclosedAprField;
        public string LockedDisclosedAprField { get { return _lockedDisclosedAprField; } set { _lockedDisclosedAprField = value; } }
        private Value<string> _lockedDisclosedByField;
        public string LockedDisclosedByField { get { return _lockedDisclosedByField; } set { _lockedDisclosedByField = value; } }
        private Value<string> _lockedDisclosedFinanceChargeField;
        public string LockedDisclosedFinanceChargeField { get { return _lockedDisclosedFinanceChargeField; } set { _lockedDisclosedFinanceChargeField = value; } }
        private Value<DateTime?> _lockedDisclosedReceivedDate;
        public DateTime? LockedDisclosedReceivedDate { get { return _lockedDisclosedReceivedDate; } set { _lockedDisclosedReceivedDate = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _manuallyCreated;
        public string ManuallyCreated { get { return _manuallyCreated; } set { _manuallyCreated = value; } }
        private Value<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        private Value<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        private Value<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        private Value<string> _propertyZip;
        public string PropertyZip { get { return _propertyZip; } set { _propertyZip = value; } }
        private Value<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get { return _receivedDate; } set { _receivedDate = value; } }
        private Value<List<LogSnapshotField>> _snapshotFields;
        public List<LogSnapshotField> SnapshotFields { get { return _snapshotFields; } set { _snapshotFields = value; } }
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _alertsXml.Clean
                    && _applicationDate.Clean
                    && _borrowerName.Clean
                    && _borrowerPairId.Clean
                    && _coBorrowerName.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _containGfe.Clean
                    && _containSafeHarbor.Clean
                    && _containTil.Clean
                    && _dateUtc.Clean
                    && _disclosedAPR.Clean
                    && _disclosedBy.Clean
                    && _disclosedByFullName.Clean
                    && _disclosedMethod.Clean
                    && _disclosureCreatedDttmUtc.Clean
                    && _eDisclosureApplicationPackageIndicator.Clean
                    && _eDisclosureApprovalPackageIndicator.Clean
                    && _eDisclosureBorrowerAcceptConsentDate.Clean
                    && _eDisclosureBorrowereSignedDate.Clean
                    && _eDisclosureBorrowerRejectConsentDate.Clean
                    && _eDisclosureBorrowerViewConsentDate.Clean
                    && _eDisclosureBorrowerViewMessageDate.Clean
                    && _eDisclosureBorrowerWetSignedDate.Clean
                    && _eDisclosureCoBorrowerAcceptConsentDate.Clean
                    && _eDisclosureCoBorrowereSignedDate.Clean
                    && _eDisclosureCoBorrowerRejectConsentDate.Clean
                    && _eDisclosureCoBorrowerViewConsentDate.Clean
                    && _eDisclosureCoBorrowerViewMessageDate.Clean
                    && _eDisclosureCoBorrowerWebSignedDate.Clean
                    && _eDisclosureConsentPdf.Clean
                    && _eDisclosureDisclosedMessage.Clean
                    && _eDisclosureLockPackageIndicator.Clean
                    && _eDisclosureManualFulfillmentComment.Clean
                    && _eDisclosureManualFulfillmentDate.Clean
                    && _eDisclosureManualFulfillmentMethod.Clean
                    && _eDisclosureManuallyFulfilledBy.Clean
                    && _eDisclosurePackageCreatedDate.Clean
                    && _eDisclosurePackageId.Clean
                    && _eDisclosurePackageViewableFile.Clean
                    && _eDisclosureThreeDayPackageIndicator.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _financeCharge.Clean
                    && _forms.Clean
                    && _formsXml.Clean
                    && _fulfillmentOrderedBy.Clean
                    && _fullfillmentProcessedDate.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isDisclosed.Clean
                    && _isDisclosedAprLocked.Clean
                    && _isDisclosedByLocked.Clean
                    && _isDisclosedFinanceChargeLocked.Clean
                    && _isDisclosedReceivedDateLocked.Clean
                    && _isLocked.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isWetSignedIndicator.Clean
                    && _loanAmount.Clean
                    && _loanProgram.Clean
                    && _lockedDisclosedAprField.Clean
                    && _lockedDisclosedByField.Clean
                    && _lockedDisclosedFinanceChargeField.Clean
                    && _lockedDisclosedReceivedDate.Clean
                    && _logRecordIndex.Clean
                    && _manuallyCreated.Clean
                    && _propertyAddress.Clean
                    && _propertyCity.Clean
                    && _propertyState.Clean
                    && _propertyZip.Clean
                    && _receivedDate.Clean
                    && _snapshotFields.Clean
                    && _snapshotXml.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _alertsXml; v1.Clean = value; _alertsXml = v1;
                var v2 = _applicationDate; v2.Clean = value; _applicationDate = v2;
                var v3 = _borrowerName; v3.Clean = value; _borrowerName = v3;
                var v4 = _borrowerPairId; v4.Clean = value; _borrowerPairId = v4;
                var v5 = _coBorrowerName; v5.Clean = value; _coBorrowerName = v5;
                var v6 = _commentList; v6.Clean = value; _commentList = v6;
                var v7 = _commentListXml; v7.Clean = value; _commentListXml = v7;
                var v8 = _comments; v8.Clean = value; _comments = v8;
                var v9 = _containGfe; v9.Clean = value; _containGfe = v9;
                var v10 = _containSafeHarbor; v10.Clean = value; _containSafeHarbor = v10;
                var v11 = _containTil; v11.Clean = value; _containTil = v11;
                var v12 = _dateUtc; v12.Clean = value; _dateUtc = v12;
                var v13 = _disclosedAPR; v13.Clean = value; _disclosedAPR = v13;
                var v14 = _disclosedBy; v14.Clean = value; _disclosedBy = v14;
                var v15 = _disclosedByFullName; v15.Clean = value; _disclosedByFullName = v15;
                var v16 = _disclosedMethod; v16.Clean = value; _disclosedMethod = v16;
                var v17 = _disclosureCreatedDttmUtc; v17.Clean = value; _disclosureCreatedDttmUtc = v17;
                var v18 = _eDisclosureApplicationPackageIndicator; v18.Clean = value; _eDisclosureApplicationPackageIndicator = v18;
                var v19 = _eDisclosureApprovalPackageIndicator; v19.Clean = value; _eDisclosureApprovalPackageIndicator = v19;
                var v20 = _eDisclosureBorrowerAcceptConsentDate; v20.Clean = value; _eDisclosureBorrowerAcceptConsentDate = v20;
                var v21 = _eDisclosureBorrowereSignedDate; v21.Clean = value; _eDisclosureBorrowereSignedDate = v21;
                var v22 = _eDisclosureBorrowerRejectConsentDate; v22.Clean = value; _eDisclosureBorrowerRejectConsentDate = v22;
                var v23 = _eDisclosureBorrowerViewConsentDate; v23.Clean = value; _eDisclosureBorrowerViewConsentDate = v23;
                var v24 = _eDisclosureBorrowerViewMessageDate; v24.Clean = value; _eDisclosureBorrowerViewMessageDate = v24;
                var v25 = _eDisclosureBorrowerWetSignedDate; v25.Clean = value; _eDisclosureBorrowerWetSignedDate = v25;
                var v26 = _eDisclosureCoBorrowerAcceptConsentDate; v26.Clean = value; _eDisclosureCoBorrowerAcceptConsentDate = v26;
                var v27 = _eDisclosureCoBorrowereSignedDate; v27.Clean = value; _eDisclosureCoBorrowereSignedDate = v27;
                var v28 = _eDisclosureCoBorrowerRejectConsentDate; v28.Clean = value; _eDisclosureCoBorrowerRejectConsentDate = v28;
                var v29 = _eDisclosureCoBorrowerViewConsentDate; v29.Clean = value; _eDisclosureCoBorrowerViewConsentDate = v29;
                var v30 = _eDisclosureCoBorrowerViewMessageDate; v30.Clean = value; _eDisclosureCoBorrowerViewMessageDate = v30;
                var v31 = _eDisclosureCoBorrowerWebSignedDate; v31.Clean = value; _eDisclosureCoBorrowerWebSignedDate = v31;
                var v32 = _eDisclosureConsentPdf; v32.Clean = value; _eDisclosureConsentPdf = v32;
                var v33 = _eDisclosureDisclosedMessage; v33.Clean = value; _eDisclosureDisclosedMessage = v33;
                var v34 = _eDisclosureLockPackageIndicator; v34.Clean = value; _eDisclosureLockPackageIndicator = v34;
                var v35 = _eDisclosureManualFulfillmentComment; v35.Clean = value; _eDisclosureManualFulfillmentComment = v35;
                var v36 = _eDisclosureManualFulfillmentDate; v36.Clean = value; _eDisclosureManualFulfillmentDate = v36;
                var v37 = _eDisclosureManualFulfillmentMethod; v37.Clean = value; _eDisclosureManualFulfillmentMethod = v37;
                var v38 = _eDisclosureManuallyFulfilledBy; v38.Clean = value; _eDisclosureManuallyFulfilledBy = v38;
                var v39 = _eDisclosurePackageCreatedDate; v39.Clean = value; _eDisclosurePackageCreatedDate = v39;
                var v40 = _eDisclosurePackageId; v40.Clean = value; _eDisclosurePackageId = v40;
                var v41 = _eDisclosurePackageViewableFile; v41.Clean = value; _eDisclosurePackageViewableFile = v41;
                var v42 = _eDisclosureThreeDayPackageIndicator; v42.Clean = value; _eDisclosureThreeDayPackageIndicator = v42;
                var v43 = _fileAttachmentsMigrated; v43.Clean = value; _fileAttachmentsMigrated = v43;
                var v44 = _financeCharge; v44.Clean = value; _financeCharge = v44;
                var v45 = _forms; v45.Clean = value; _forms = v45;
                var v46 = _formsXml; v46.Clean = value; _formsXml = v46;
                var v47 = _fulfillmentOrderedBy; v47.Clean = value; _fulfillmentOrderedBy = v47;
                var v48 = _fullfillmentProcessedDate; v48.Clean = value; _fullfillmentProcessedDate = v48;
                var v49 = _guid; v49.Clean = value; _guid = v49;
                var v50 = _id; v50.Clean = value; _id = v50;
                var v51 = _isDisclosed; v51.Clean = value; _isDisclosed = v51;
                var v52 = _isDisclosedAprLocked; v52.Clean = value; _isDisclosedAprLocked = v52;
                var v53 = _isDisclosedByLocked; v53.Clean = value; _isDisclosedByLocked = v53;
                var v54 = _isDisclosedFinanceChargeLocked; v54.Clean = value; _isDisclosedFinanceChargeLocked = v54;
                var v55 = _isDisclosedReceivedDateLocked; v55.Clean = value; _isDisclosedReceivedDateLocked = v55;
                var v56 = _isLocked; v56.Clean = value; _isLocked = v56;
                var v57 = _isSystemSpecificIndicator; v57.Clean = value; _isSystemSpecificIndicator = v57;
                var v58 = _isWetSignedIndicator; v58.Clean = value; _isWetSignedIndicator = v58;
                var v59 = _loanAmount; v59.Clean = value; _loanAmount = v59;
                var v60 = _loanProgram; v60.Clean = value; _loanProgram = v60;
                var v61 = _lockedDisclosedAprField; v61.Clean = value; _lockedDisclosedAprField = v61;
                var v62 = _lockedDisclosedByField; v62.Clean = value; _lockedDisclosedByField = v62;
                var v63 = _lockedDisclosedFinanceChargeField; v63.Clean = value; _lockedDisclosedFinanceChargeField = v63;
                var v64 = _lockedDisclosedReceivedDate; v64.Clean = value; _lockedDisclosedReceivedDate = v64;
                var v65 = _logRecordIndex; v65.Clean = value; _logRecordIndex = v65;
                var v66 = _manuallyCreated; v66.Clean = value; _manuallyCreated = v66;
                var v67 = _propertyAddress; v67.Clean = value; _propertyAddress = v67;
                var v68 = _propertyCity; v68.Clean = value; _propertyCity = v68;
                var v69 = _propertyState; v69.Clean = value; _propertyState = v69;
                var v70 = _propertyZip; v70.Clean = value; _propertyZip = v70;
                var v71 = _receivedDate; v71.Clean = value; _receivedDate = v71;
                var v72 = _snapshotFields; v72.Clean = value; _snapshotFields = v72;
                var v73 = _snapshotXml; v73.Clean = value; _snapshotXml = v73;
                var v74 = _systemId; v74.Clean = value; _systemId = v74;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}