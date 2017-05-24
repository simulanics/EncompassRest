using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate3
    {
        private Value<string> _appraisal;
        public string Appraisal { get { return _appraisal; } set { _appraisal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisal() => !_appraisal.Clean;
        private Value<string> _assumption;
        public string Assumption { get { return _assumption; } set { _assumption = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumption() => !_assumption.Clean;
        private Value<bool?> _constructionLoan;
        public bool? ConstructionLoan { get { return _constructionLoan; } set { _constructionLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionLoan() => !_constructionLoan.Clean;
        private Value<bool?> _homeownerInsurance;
        public bool? HomeownerInsurance { get { return _homeownerInsurance; } set { _homeownerInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeownerInsurance() => !_homeownerInsurance.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<int?> _in5YearsPrincipalYouWillHavePaidOff;
        public int? In5YearsPrincipalYouWillHavePaidOff { get { return _in5YearsPrincipalYouWillHavePaidOff; } set { _in5YearsPrincipalYouWillHavePaidOff = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIn5YearsPrincipalYouWillHavePaidOff() => !_in5YearsPrincipalYouWillHavePaidOff.Clean;
        private Value<int?> _in5YearsTotalYouWillHavePaid;
        public int? In5YearsTotalYouWillHavePaid { get { return _in5YearsTotalYouWillHavePaid; } set { _in5YearsTotalYouWillHavePaid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIn5YearsTotalYouWillHavePaid() => !_in5YearsTotalYouWillHavePaid.Clean;
        private Value<string> _lenderEmail;
        public string LenderEmail { get { return _lenderEmail; } set { _lenderEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderEmail() => !_lenderEmail.Clean;
        private Value<string> _lenderLicenseID;
        public string LenderLicenseID { get { return _lenderLicenseID; } set { _lenderLicenseID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLicenseID() => !_lenderLicenseID.Clean;
        private Value<string> _lenderLicenseState;
        public string LenderLicenseState { get { return _lenderLicenseState; } set { _lenderLicenseState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLicenseState() => !_lenderLicenseState.Clean;
        private Value<string> _lenderLoanOfficer;
        public string LenderLoanOfficer { get { return _lenderLoanOfficer; } set { _lenderLoanOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficer() => !_lenderLoanOfficer.Clean;
        private Value<string> _lenderLoanOfficerLicenseState;
        public string LenderLoanOfficerLicenseState { get { return _lenderLoanOfficerLicenseState; } set { _lenderLoanOfficerLicenseState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficerLicenseState() => !_lenderLoanOfficerLicenseState.Clean;
        private Value<string> _lenderLoanOfficerNMLSId;
        public string LenderLoanOfficerNMLSId { get { return _lenderLoanOfficerNMLSId; } set { _lenderLoanOfficerNMLSId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderLoanOfficerNMLSId() => !_lenderLoanOfficerNMLSId.Clean;
        private Value<string> _lenderPhone;
        public string LenderPhone { get { return _lenderPhone; } set { _lenderPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPhone() => !_lenderPhone.Clean;
        private Value<string> _mortgageBrokerEmail;
        public string MortgageBrokerEmail { get { return _mortgageBrokerEmail; } set { _mortgageBrokerEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerEmail() => !_mortgageBrokerEmail.Clean;
        private Value<string> _mortgageBrokerLicenseID;
        public string MortgageBrokerLicenseID { get { return _mortgageBrokerLicenseID; } set { _mortgageBrokerLicenseID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLicenseID() => !_mortgageBrokerLicenseID.Clean;
        private Value<string> _mortgageBrokerLicenseState;
        public string MortgageBrokerLicenseState { get { return _mortgageBrokerLicenseState; } set { _mortgageBrokerLicenseState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLicenseState() => !_mortgageBrokerLicenseState.Clean;
        private Value<string> _mortgageBrokerLoanOfficer;
        public string MortgageBrokerLoanOfficer { get { return _mortgageBrokerLoanOfficer; } set { _mortgageBrokerLoanOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficer() => !_mortgageBrokerLoanOfficer.Clean;
        private Value<string> _mortgageBrokerLoanOfficerLicenseID;
        public string MortgageBrokerLoanOfficerLicenseID { get { return _mortgageBrokerLoanOfficerLicenseID; } set { _mortgageBrokerLoanOfficerLicenseID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerLicenseID() => !_mortgageBrokerLoanOfficerLicenseID.Clean;
        private Value<string> _mortgageBrokerLoanOfficerLicenseState;
        public string MortgageBrokerLoanOfficerLicenseState { get { return _mortgageBrokerLoanOfficerLicenseState; } set { _mortgageBrokerLoanOfficerLicenseState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerLicenseState() => !_mortgageBrokerLoanOfficerLicenseState.Clean;
        private Value<string> _mortgageBrokerLoanOfficerNMLSId;
        public string MortgageBrokerLoanOfficerNMLSId { get { return _mortgageBrokerLoanOfficerNMLSId; } set { _mortgageBrokerLoanOfficerNMLSId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerLoanOfficerNMLSId() => !_mortgageBrokerLoanOfficerNMLSId.Clean;
        private Value<string> _mortgageBrokerPhone;
        public string MortgageBrokerPhone { get { return _mortgageBrokerPhone; } set { _mortgageBrokerPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerPhone() => !_mortgageBrokerPhone.Clean;
        private Value<string> _mortgageLenderLoanOfficerLicenseID;
        public string MortgageLenderLoanOfficerLicenseID { get { return _mortgageLenderLoanOfficerLicenseID; } set { _mortgageLenderLoanOfficerLicenseID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageLenderLoanOfficerLicenseID() => !_mortgageLenderLoanOfficerLicenseID.Clean;
        private Value<string> _servicing;
        public string Servicing { get { return _servicing; } set { _servicing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicing() => !_servicing.Clean;
        private Value<string> _signatureType;
        public string SignatureType { get { return _signatureType; } set { _signatureType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureType() => !_signatureType.Clean;
        private Value<decimal?> _totalInterestPercentage;
        public decimal? TotalInterestPercentage { get { return _totalInterestPercentage; } set { _totalInterestPercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterestPercentage() => !_totalInterestPercentage.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisal.Clean
                    && _assumption.Clean
                    && _constructionLoan.Clean
                    && _homeownerInsurance.Clean
                    && _id.Clean
                    && _in5YearsPrincipalYouWillHavePaidOff.Clean
                    && _in5YearsTotalYouWillHavePaid.Clean
                    && _lenderEmail.Clean
                    && _lenderLicenseID.Clean
                    && _lenderLicenseState.Clean
                    && _lenderLoanOfficer.Clean
                    && _lenderLoanOfficerLicenseState.Clean
                    && _lenderLoanOfficerNMLSId.Clean
                    && _lenderPhone.Clean
                    && _mortgageBrokerEmail.Clean
                    && _mortgageBrokerLicenseID.Clean
                    && _mortgageBrokerLicenseState.Clean
                    && _mortgageBrokerLoanOfficer.Clean
                    && _mortgageBrokerLoanOfficerLicenseID.Clean
                    && _mortgageBrokerLoanOfficerLicenseState.Clean
                    && _mortgageBrokerLoanOfficerNMLSId.Clean
                    && _mortgageBrokerPhone.Clean
                    && _mortgageLenderLoanOfficerLicenseID.Clean
                    && _servicing.Clean
                    && _signatureType.Clean
                    && _totalInterestPercentage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _appraisal; v0.Clean = value; _appraisal = v0;
                var v1 = _assumption; v1.Clean = value; _assumption = v1;
                var v2 = _constructionLoan; v2.Clean = value; _constructionLoan = v2;
                var v3 = _homeownerInsurance; v3.Clean = value; _homeownerInsurance = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _in5YearsPrincipalYouWillHavePaidOff; v5.Clean = value; _in5YearsPrincipalYouWillHavePaidOff = v5;
                var v6 = _in5YearsTotalYouWillHavePaid; v6.Clean = value; _in5YearsTotalYouWillHavePaid = v6;
                var v7 = _lenderEmail; v7.Clean = value; _lenderEmail = v7;
                var v8 = _lenderLicenseID; v8.Clean = value; _lenderLicenseID = v8;
                var v9 = _lenderLicenseState; v9.Clean = value; _lenderLicenseState = v9;
                var v10 = _lenderLoanOfficer; v10.Clean = value; _lenderLoanOfficer = v10;
                var v11 = _lenderLoanOfficerLicenseState; v11.Clean = value; _lenderLoanOfficerLicenseState = v11;
                var v12 = _lenderLoanOfficerNMLSId; v12.Clean = value; _lenderLoanOfficerNMLSId = v12;
                var v13 = _lenderPhone; v13.Clean = value; _lenderPhone = v13;
                var v14 = _mortgageBrokerEmail; v14.Clean = value; _mortgageBrokerEmail = v14;
                var v15 = _mortgageBrokerLicenseID; v15.Clean = value; _mortgageBrokerLicenseID = v15;
                var v16 = _mortgageBrokerLicenseState; v16.Clean = value; _mortgageBrokerLicenseState = v16;
                var v17 = _mortgageBrokerLoanOfficer; v17.Clean = value; _mortgageBrokerLoanOfficer = v17;
                var v18 = _mortgageBrokerLoanOfficerLicenseID; v18.Clean = value; _mortgageBrokerLoanOfficerLicenseID = v18;
                var v19 = _mortgageBrokerLoanOfficerLicenseState; v19.Clean = value; _mortgageBrokerLoanOfficerLicenseState = v19;
                var v20 = _mortgageBrokerLoanOfficerNMLSId; v20.Clean = value; _mortgageBrokerLoanOfficerNMLSId = v20;
                var v21 = _mortgageBrokerPhone; v21.Clean = value; _mortgageBrokerPhone = v21;
                var v22 = _mortgageLenderLoanOfficerLicenseID; v22.Clean = value; _mortgageLenderLoanOfficerLicenseID = v22;
                var v23 = _servicing; v23.Clean = value; _servicing = v23;
                var v24 = _signatureType; v24.Clean = value; _signatureType = v24;
                var v25 = _totalInterestPercentage; v25.Clean = value; _totalInterestPercentage = v25;
                _settingClean = 0;
            }
        }
    }
}