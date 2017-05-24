using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagementItem
    {
        private Value<decimal?> _atPercent;
        public decimal? AtPercent { get { return _atPercent; } set { _atPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAtPercent() => !_atPercent.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _plusAmount;
        public decimal? PlusAmount { get { return _plusAmount; } set { _plusAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlusAmount() => !_plusAmount.Clean;
        private Value<int?> _profitManagementItemIndex;
        public int? ProfitManagementItemIndex { get { return _profitManagementItemIndex; } set { _profitManagementItemIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProfitManagementItemIndex() => !_profitManagementItemIndex.Clean;
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !_total.Clean;
        private Value<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeType() => !_type.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _atPercent.Clean
                    && _description.Clean
                    && _id.Clean
                    && _plusAmount.Clean
                    && _profitManagementItemIndex.Clean
                    && _total.Clean
                    && _type.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _atPercent; v0.Clean = value; _atPercent = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _plusAmount; v3.Clean = value; _plusAmount = v3;
                var v4 = _profitManagementItemIndex; v4.Clean = value; _profitManagementItemIndex = v4;
                var v5 = _total; v5.Clean = value; _total = v5;
                var v6 = _type; v6.Clean = value; _type = v6;
                _settingClean = 0;
            }
        }
    }
}