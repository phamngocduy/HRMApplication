using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using HRM.QLThinhGiang.Models;
using HRM.QLThinhGiang.Models.Mapping;
namespace HRM.QLThinhGiang.Models
{
    public partial class HRMDB_Entities : DbContext
    {
        static HRMDB_Entities()
        {
            Database.SetInitializer<HRMDB_Entities>(null);
        }

        public HRMDB_Entities()
            : base("Name=HRMDB0Entities")
        {
        }

        public DbSet<ChungChi> ChungChi { get; set; }
        public DbSet<DiaPhuong> DiaPhuong { get; set; }
        public DbSet<gvDuLieuGioGiang> gvDuLieuGioGiang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<nvBangCap> nvBangCap { get; set; }
        public DbSet<nvDiaChiNha> nvDiaChiNha { get; set; }
        public DbSet<nvQHGiaDinh> nvQHGiaDinh { get; set; }
        public DbSet<nvSoYeuLyLich> nvSoYeuLyLich { get; set; }
        public DbSet<nvTheDinhDanh> nvTheDinhDanh { get; set; }
        public DbSet<sysdiagram> sysdiagram { get; set; }
        public DbSet<dsDiaChiNha> dsDiaChiNha { get; set; }
        public DbSet<dsNhanVien> dsNhanVien { get; set; }
        public DbSet<dsQHGiaDinh> dsQHGiaDinh { get; set; }
        public DbSet<dsSoYeuLyLich> dsSoYeuLyLich { get; set; }
        public DbSet<dsTheDinhDanh> dsTheDinhDanh { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChungChiMap());
            modelBuilder.Configurations.Add(new DiaPhuongMap());
            modelBuilder.Configurations.Add(new gvDuLieuGioGiangMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new nvBangCapMap());
            modelBuilder.Configurations.Add(new nvDiaChiNhaMap());
            modelBuilder.Configurations.Add(new nvQHGiaDinhMap());
            modelBuilder.Configurations.Add(new nvSoYeuLyLichMap());
            modelBuilder.Configurations.Add(new nvTheDinhDanhMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new dsDiaChiNhaMap());
            modelBuilder.Configurations.Add(new dsNhanVienMap());
            modelBuilder.Configurations.Add(new dsQHGiaDinhMap());
            modelBuilder.Configurations.Add(new dsSoYeuLyLichMap());
            modelBuilder.Configurations.Add(new dsTheDinhDanhMap());
        }
    }
}
