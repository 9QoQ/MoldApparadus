﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YonYuEntities : DbContext
    {
        public YonYuEntities()
            : base("name=YonYuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ZTIPP0001A> ZTIPP0001A { get; set; }
        public virtual DbSet<ZTIPP0002A> ZTIPP0002A { get; set; }
        public virtual DbSet<ZTIPP0002B> ZTIPP0002B { get; set; }
        public virtual DbSet<ZTIPP0003A> ZTIPP0003A { get; set; }
        public virtual DbSet<ZTIPP0004A> ZTIPP0004A { get; set; }
        public virtual DbSet<ApparadusConfig> ApparadusConfig { get; set; }
        public virtual DbSet<BartenderConfig> BartenderConfig { get; set; }
        public virtual DbSet<CustomerComplaintRecord> CustomerComplaintRecord { get; set; }
        public virtual DbSet<EventCodeConfig> EventCodeConfig { get; set; }
        public virtual DbSet<FactoryConfig> FactoryConfig { get; set; }
        public virtual DbSet<FloorInventory> FloorInventory { get; set; }
        public virtual DbSet<GroupSet> GroupSet { get; set; }
        public virtual DbSet<MachineConfig> MachineConfig { get; set; }
        public virtual DbSet<ManufacturerConfig> ManufacturerConfig { get; set; }
        public virtual DbSet<MoldConfig> MoldConfig { get; set; }
        public virtual DbSet<MoldIDAssociationConfig> MoldIDAssociationConfig { get; set; }
        public virtual DbSet<MoldTransaction> MoldTransaction { get; set; }
        public virtual DbSet<PalletTag> PalletTag { get; set; }
        public virtual DbSet<PostDateConfig> PostDateConfig { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<ProductionLog> ProductionLog { get; set; }
        public virtual DbSet<ProjectCodeConfig> ProjectCodeConfig { get; set; }
        public virtual DbSet<QualityInvalidRecord> QualityInvalidRecord { get; set; }
        public virtual DbSet<ReworkScrapRecord> ReworkScrapRecord { get; set; }
        public virtual DbSet<ScrapRecord> ScrapRecord { get; set; }
        public virtual DbSet<StockConfig> StockConfig { get; set; }
        public virtual DbSet<StockInOrder> StockInOrder { get; set; }
        public virtual DbSet<TransactionConfig> TransactionConfig { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<WorkerConfig> WorkerConfig { get; set; }
        public virtual DbSet<WorkingHours> WorkingHours { get; set; }
        public virtual DbSet<WorkingHoursDescription> WorkingHoursDescription { get; set; }
        public virtual DbSet<YearShiftConfig> YearShiftConfig { get; set; }
    }
}
