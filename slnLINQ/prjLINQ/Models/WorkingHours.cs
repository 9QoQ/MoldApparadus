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
    
    public partial class WorkingHours
    {
        public long wID { get; set; }
        public string FactoryID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Shift { get; set; }
        public string WorkorderNo { get; set; }
        public string MaterialName { get; set; }
        public string MachineID { get; set; }
        public string Process { get; set; }
        public string ProcessDescription { get; set; }
        public string EventType { get; set; }
        public string EventCode { get; set; }
        public Nullable<System.DateTime> EventDateTime { get; set; }
        public Nullable<decimal> WorkingTime { get; set; }
        public Nullable<decimal> AbnormalTime { get; set; }
        public string Workers { get; set; }
        public string OperationType { get; set; }
        public string ProjectCode { get; set; }
        public string ProductionType { get; set; }
        public Nullable<decimal> Mold { get; set; }
        public Nullable<decimal> Test { get; set; }
        public Nullable<decimal> Malfunction { get; set; }
        public Nullable<decimal> Adjustment { get; set; }
        public Nullable<decimal> MaterialAbnormal { get; set; }
        public Nullable<decimal> MoldAbnormal { get; set; }
        public Nullable<decimal> Other { get; set; }
        public Nullable<decimal> InvalidTime { get; set; }
        public string InvalidDescription { get; set; }
        public string MoldNo { get; set; }
        public string MoldName { get; set; }
        public string DepartmentNo { get; set; }
        public string MoldStatus { get; set; }
        public string ProjectDescription { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> ProductionQty { get; set; }
        public Nullable<decimal> QualifiedQty { get; set; }
        public Nullable<decimal> ScrapQty { get; set; }
        public string Unit { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<System.DateTime> LmTime { get; set; }
    }
}