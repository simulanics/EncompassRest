using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZInterestRatePeriod
    {
        private Value<DateTime?> _adjustmentDate;
        public DateTime? AdjustmentDate { get { return _adjustmentDate; } set { _adjustmentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDate() => !_adjustmentDate.Clean;
        private Value<int?> _adjustmentMonths;
        public int? AdjustmentMonths { get { return _adjustmentMonths; } set { _adjustmentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentMonths() => !_adjustmentMonths.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _interestPayment;
        public decimal? InterestPayment { get { return _interestPayment; } set { _interestPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestPayment() => !_interestPayment.Clean;
        private Value<decimal?> _interestPrincipalPayment;
        public decimal? InterestPrincipalPayment { get { return _interestPrincipalPayment; } set { _interestPrincipalPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestPrincipalPayment() => !_interestPrincipalPayment.Clean;
        private Value<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get { return _interestRatePercent; } set { _interestRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRatePercent() => !_interestRatePercent.Clean;
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !_monthlyPayment.Clean;
        private Value<decimal?> _principalPayment;
        public decimal? PrincipalPayment { get { return _principalPayment; } set { _principalPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalPayment() => !_principalPayment.Clean;
        private Value<string> _regulationZInterestRatePeriodType;
        public string RegulationZInterestRatePeriodType { get { return _regulationZInterestRatePeriodType; } set { _regulationZInterestRatePeriodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZInterestRatePeriodType() => !_regulationZInterestRatePeriodType.Clean;
        private Value<decimal?> _taxInsuranceAmount;
        public decimal? TaxInsuranceAmount { get { return _taxInsuranceAmount; } set { _taxInsuranceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxInsuranceAmount() => !_taxInsuranceAmount.Clean;
        private Value<decimal?> _totalPayment;
        public decimal? TotalPayment { get { return _totalPayment; } set { _totalPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPayment() => !_totalPayment.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustmentDate.Clean
                    && _adjustmentMonths.Clean
                    && _id.Clean
                    && _interestPayment.Clean
                    && _interestPrincipalPayment.Clean
                    && _interestRatePercent.Clean
                    && _monthlyPayment.Clean
                    && _principalPayment.Clean
                    && _regulationZInterestRatePeriodType.Clean
                    && _taxInsuranceAmount.Clean
                    && _totalPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _adjustmentDate; v0.Clean = value; _adjustmentDate = v0;
                var v1 = _adjustmentMonths; v1.Clean = value; _adjustmentMonths = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _interestPayment; v3.Clean = value; _interestPayment = v3;
                var v4 = _interestPrincipalPayment; v4.Clean = value; _interestPrincipalPayment = v4;
                var v5 = _interestRatePercent; v5.Clean = value; _interestRatePercent = v5;
                var v6 = _monthlyPayment; v6.Clean = value; _monthlyPayment = v6;
                var v7 = _principalPayment; v7.Clean = value; _principalPayment = v7;
                var v8 = _regulationZInterestRatePeriodType; v8.Clean = value; _regulationZInterestRatePeriodType = v8;
                var v9 = _taxInsuranceAmount; v9.Clean = value; _taxInsuranceAmount = v9;
                var v10 = _totalPayment; v10.Clean = value; _totalPayment = v10;
                _settingClean = 0;
            }
        }
    }
}