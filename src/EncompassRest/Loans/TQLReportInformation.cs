using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLReportInformation : IClean
    {
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _borrowerID1;
        public string BorrowerID1 { get { return _borrowerID1; } set { _borrowerID1 = value; } }
        private Value<string> _borrowerID2;
        public string BorrowerID2 { get { return _borrowerID2; } set { _borrowerID2 = value; } }
        private Value<string> _borrowerID3;
        public string BorrowerID3 { get { return _borrowerID3; } set { _borrowerID3 = value; } }
        private Value<string> _borrowerID4;
        public string BorrowerID4 { get { return _borrowerID4; } set { _borrowerID4 = value; } }
        private Value<DateTime?> _completedDate;
        public DateTime? CompletedDate { get { return _completedDate; } set { _completedDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _investor;
        public string Investor { get { return _investor; } set { _investor = value; } }
        private Value<DateTime?> _orderDate;
        public DateTime? OrderDate { get { return _orderDate; } set { _orderDate = value; } }
        private Value<string> _orderNumber;
        public string OrderNumber { get { return _orderNumber; } set { _orderNumber = value; } }
        private Value<string> _orderStatus;
        public string OrderStatus { get { return _orderStatus; } set { _orderStatus = value; } }
        private Value<decimal?> _percentVariance1;
        public decimal? PercentVariance1 { get { return _percentVariance1; } set { _percentVariance1 = value; } }
        private Value<decimal?> _percentVariance2;
        public decimal? PercentVariance2 { get { return _percentVariance2; } set { _percentVariance2 = value; } }
        private Value<decimal?> _percentVariance3;
        public decimal? PercentVariance3 { get { return _percentVariance3; } set { _percentVariance3 = value; } }
        private Value<decimal?> _percentVariance4;
        public decimal? PercentVariance4 { get { return _percentVariance4; } set { _percentVariance4 = value; } }
        private Value<string> _productsOrdered;
        public string ProductsOrdered { get { return _productsOrdered; } set { _productsOrdered = value; } }
        private Value<string> _reportYear1;
        public string ReportYear1 { get { return _reportYear1; } set { _reportYear1 = value; } }
        private Value<string> _reportYear2;
        public string ReportYear2 { get { return _reportYear2; } set { _reportYear2 = value; } }
        private Value<string> _reportYear3;
        public string ReportYear3 { get { return _reportYear3; } set { _reportYear3 = value; } }
        private Value<string> _reportYear4;
        public string ReportYear4 { get { return _reportYear4; } set { _reportYear4 = value; } }
        private Value<decimal?> _totalIncome1;
        public decimal? TotalIncome1 { get { return _totalIncome1; } set { _totalIncome1 = value; } }
        private Value<decimal?> _totalIncome2;
        public decimal? TotalIncome2 { get { return _totalIncome2; } set { _totalIncome2 = value; } }
        private Value<decimal?> _totalIncome3;
        public decimal? TotalIncome3 { get { return _totalIncome3; } set { _totalIncome3 = value; } }
        private Value<decimal?> _totalIncome4;
        public decimal? TotalIncome4 { get { return _totalIncome4; } set { _totalIncome4 = value; } }
        private Value<string> _transcriptType;
        public string TranscriptType { get { return _transcriptType; } set { _transcriptType = value; } }
        private Value<string> _userID;
        public string UserID { get { return _userID; } set { _userID = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _altId.Clean
                    && _borrowerID1.Clean
                    && _borrowerID2.Clean
                    && _borrowerID3.Clean
                    && _borrowerID4.Clean
                    && _completedDate.Clean
                    && _id.Clean
                    && _investor.Clean
                    && _orderDate.Clean
                    && _orderNumber.Clean
                    && _orderStatus.Clean
                    && _percentVariance1.Clean
                    && _percentVariance2.Clean
                    && _percentVariance3.Clean
                    && _percentVariance4.Clean
                    && _productsOrdered.Clean
                    && _reportYear1.Clean
                    && _reportYear2.Clean
                    && _reportYear3.Clean
                    && _reportYear4.Clean
                    && _totalIncome1.Clean
                    && _totalIncome2.Clean
                    && _totalIncome3.Clean
                    && _totalIncome4.Clean
                    && _transcriptType.Clean
                    && _userID.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _altId; v0.Clean = value; _altId = v0;
                var v1 = _borrowerID1; v1.Clean = value; _borrowerID1 = v1;
                var v2 = _borrowerID2; v2.Clean = value; _borrowerID2 = v2;
                var v3 = _borrowerID3; v3.Clean = value; _borrowerID3 = v3;
                var v4 = _borrowerID4; v4.Clean = value; _borrowerID4 = v4;
                var v5 = _completedDate; v5.Clean = value; _completedDate = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _investor; v7.Clean = value; _investor = v7;
                var v8 = _orderDate; v8.Clean = value; _orderDate = v8;
                var v9 = _orderNumber; v9.Clean = value; _orderNumber = v9;
                var v10 = _orderStatus; v10.Clean = value; _orderStatus = v10;
                var v11 = _percentVariance1; v11.Clean = value; _percentVariance1 = v11;
                var v12 = _percentVariance2; v12.Clean = value; _percentVariance2 = v12;
                var v13 = _percentVariance3; v13.Clean = value; _percentVariance3 = v13;
                var v14 = _percentVariance4; v14.Clean = value; _percentVariance4 = v14;
                var v15 = _productsOrdered; v15.Clean = value; _productsOrdered = v15;
                var v16 = _reportYear1; v16.Clean = value; _reportYear1 = v16;
                var v17 = _reportYear2; v17.Clean = value; _reportYear2 = v17;
                var v18 = _reportYear3; v18.Clean = value; _reportYear3 = v18;
                var v19 = _reportYear4; v19.Clean = value; _reportYear4 = v19;
                var v20 = _totalIncome1; v20.Clean = value; _totalIncome1 = v20;
                var v21 = _totalIncome2; v21.Clean = value; _totalIncome2 = v21;
                var v22 = _totalIncome3; v22.Clean = value; _totalIncome3 = v22;
                var v23 = _totalIncome4; v23.Clean = value; _totalIncome4 = v23;
                var v24 = _transcriptType; v24.Clean = value; _transcriptType = v24;
                var v25 = _userID; v25.Clean = value; _userID = v25;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}