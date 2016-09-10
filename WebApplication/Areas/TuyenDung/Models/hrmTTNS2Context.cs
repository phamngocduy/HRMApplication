using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using HRM.Databases_TuyenDung.Models;
using HRM.Databases_TuyenDung.Models.Mapping;
namespace HRM.Databases_TuyenDung.Models
{
    public partial class HRMDB2Entities : DbContext
    {
        static HRMDB2Entities()
        {
            Database.SetInitializer<HRMDB2Entities>(null);
        }

        public HRMDB2Entities()
            : base("Name=HRMDB2Entities")
        {
        }

        public DbSet<dmThoiGioLamViec> dmThoiGioLamViec { get; set; }
        public DbSet<dmThoiHanHD> dmThoiHanHD { get; set; }
        public DbSet<hdCanTaoHDLD> hdCanTaoHDLD { get; set; }
        public DbSet<hdCauHinh> hdCauHinh { get; set; }
        public DbSet<hdChiTietHDLD> hdChiTietHDLD { get; set; }
        public DbSet<hdNLD> hdNLD { get; set; }
        public DbSet<hdPhuLucHD12LuuFile> hdPhuLucHD12LuuFile { get; set; }
        public DbSet<hdPhuLucHD2> hdPhuLucHD2 { get; set; }
        public DbSet<sysdiagram> sysdiagram { get; set; }
        public DbSet<tdBangCap> tdBangCap { get; set; }
        public DbSet<tdDiaChiLienLac> tdDiaChiLienLac { get; set; }
        public DbSet<tdHoKhauThuongTru> tdHoKhauThuongTru { get; set; }
        public DbSet<tdKetQuaTuyenDung> tdKetQuaTuyenDung { get; set; }
        public DbSet<tdKiemTraH> tdKiemTraH { get; set; }
        public DbSet<tdLoaiTheDinhDanh> tdLoaiTheDinhDanh { get; set; }
        public DbSet<tdNoiSinh> tdNoiSinh { get; set; }
        public DbSet<tdQuaTrinhTuyenDung> tdQuaTrinhTuyenDung { get; set; }
        public DbSet<tdTheDinhDanh> tdTheDinhDanh { get; set; }
        public DbSet<tdThongTinLienHe> tdThongTinLienHe { get; set; }
        public DbSet<tdThongTinUngTuyen> tdThongTinUngTuyen { get; set; }
        public DbSet<tdTTUngCuVien> tdTTUngCuVien { get; set; }
        public DbSet<tdXemVaXepLichHen> tdXemVaXepLichHen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new dmThoiGioLamViecMap());
            modelBuilder.Configurations.Add(new dmThoiHanHDMap());
            modelBuilder.Configurations.Add(new hdCanTaoHDLDMap());
            modelBuilder.Configurations.Add(new hdCauHinhMap());
            modelBuilder.Configurations.Add(new hdChiTietHDLDMap());
            modelBuilder.Configurations.Add(new hdNLDMap());
            modelBuilder.Configurations.Add(new hdPhuLucHD12LuuFileMap());
            modelBuilder.Configurations.Add(new hdPhuLucHD2Map());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tdBangCapMap());
            modelBuilder.Configurations.Add(new tdDiaChiLienLacMap());
            modelBuilder.Configurations.Add(new tdHoKhauThuongTruMap());
            modelBuilder.Configurations.Add(new tdKetQuaTuyenDungMap());
            modelBuilder.Configurations.Add(new tdKiemTraHMap());
            modelBuilder.Configurations.Add(new tdLoaiTheDinhDanhMap());
            modelBuilder.Configurations.Add(new tdNoiSinhMap());
            modelBuilder.Configurations.Add(new tdQuaTrinhTuyenDungMap());
            modelBuilder.Configurations.Add(new tdTheDinhDanhMap());
            modelBuilder.Configurations.Add(new tdThongTinLienHeMap());
            modelBuilder.Configurations.Add(new tdThongTinUngTuyenMap());
            modelBuilder.Configurations.Add(new tdTTUngCuVienMap());
            modelBuilder.Configurations.Add(new tdXemVaXepLichHenMap());
        }
    }
}
