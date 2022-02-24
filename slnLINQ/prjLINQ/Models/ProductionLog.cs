//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjLINQ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductionLog
    {
        public long pID { get; set; }
        public string FactoryArea { get; set; }
        public string FactoryID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string WorkorderNo { get; set; }
        public string MaterialNo { get; set; }
        public string MaterialName { get; set; }
        public string Process { get; set; }
        public string ProcessDescription { get; set; }
        public string MachineID { get; set; }
        public string Unit { get; set; }
        public Nullable<int> CartonID { get; set; }
        public Nullable<decimal> PcsCarton { get; set; }
        public Nullable<decimal> ProductionQty { get; set; }
        public Nullable<decimal> ScrapQty { get; set; }
        public string PalletCode { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Shift { get; set; }
        public Nullable<System.DateTime> QualityTime { get; set; }
        public string QualityShift { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string StockInOrderNo { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string ProductionType { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Cavity { get; set; }
        public Nullable<decimal> Period { get; set; }
        public string ScrapDescription { get; set; }
        public Nullable<long> wID { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> LmTime { get; set; }
    }
}
