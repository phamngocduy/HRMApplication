using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using HRM.QLBHXH.Models;
using HRM.QLBHXH.Models.Mapping;
namespace HRM.QLBHXH.Models
{
    public partial class HRMDB1Entities : DbContext
    {
        static HRMDB1Entities()
        {
            Database.SetInitializer<HRMDB1Entities>(null);
        }

        public HRMDB1Entities()
            : base("Name=HRMDB1Entities")
        {
        }

        public DbSet<ChiTietVayMuon> ChiTietVayMuon { get; set; }
        public DbSet<dmGiayTo> dmGiayTo { get; set; }
        public DbSet<dmLaiSuatTruyThu> dmLaiSuatTruyThu { get; set; }
        public DbSet<dmLoaiDieuChinh> dmLoaiDieuChinh { get; set; }
        public DbSet<dmLoaiTangGiam> dmLoaiTangGiam { get; set; }
        public DbSet<dmMucDichSuDung> dmMucDichSuDung { get; set; }
        public DbSet<dmMucLuongToiThieuChung> dmMucLuongToiThieuChung { get; set; }
        public DbSet<dmMucLuongToiThieuVung> dmMucLuongToiThieuVung { get; set; }
        public DbSet<dmNoiKCB> dmNoiKCB { get; set; }
        public DbSet<dmTyLeDongBHXH> dmTyLeDongBHXH { get; set; }
        public DbSet<HoanVay> HoanVay { get; set; }
        public DbSet<HoSoVayMuon> HoSoVayMuon { get; set; }
        public DbSet<KhoanVay> KhoanVay { get; set; }
        public DbSet<NhanVienVayMuon> NhanVienVayMuon { get; set; }
        public DbSet<nvbhDanhSachDieuChinhChucDanh> nvbhDanhSachDieuChinhChucDanh { get; set; }
        public DbSet<nvbhDanhSachDieuChinhTangGiam> nvbhDanhSachDieuChinhTangGiam { get; set; }
        public DbSet<nvbhLaiTruyThuBH> nvbhLaiTruyThuBH { get; set; }
        public DbSet<nvbhNhanVienBHXH> nvbhNhanVienBHXH { get; set; }
        public DbSet<nvbhPhatSinhTrongKy> nvbhPhatSinhTrongKy { get; set; }
        public DbSet<nvbhQuaTrinhBHXH> nvbhQuaTrinhBHXH { get; set; }
        public DbSet<nvbhTongHopCuoiKy> nvbhTongHopCuoiKy { get; set; }
        public DbSet<TangLaoDong> TangLaoDong { get; set; }
        public DbSet<TapTin> TapTin { get; set; }
        public DbSet<v_ChucDanh> v_ChucDanh { get; set; }
        public DbSet<v_nvbhDanhSachDieuChinhTangGiam1> v_nvbhDanhSachDieuChinhTangGiam1 { get; set; }
        public DbSet<v_nvbhNhanVienBHXH> v_nvbhNhanVienBHXH { get; set; }
        public DbSet<v_qtbhxh> v_qtbhxh { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChiTietVayMuonMap());
            modelBuilder.Configurations.Add(new dmGiayToMap());
            modelBuilder.Configurations.Add(new dmLaiSuatTruyThuMap());
            modelBuilder.Configurations.Add(new dmLoaiDieuChinhMap());
            modelBuilder.Configurations.Add(new dmLoaiTangGiamMap());
            modelBuilder.Configurations.Add(new dmMucDichSuDungMap());
            modelBuilder.Configurations.Add(new dmMucLuongToiThieuChungMap());
            modelBuilder.Configurations.Add(new dmMucLuongToiThieuVungMap());
            modelBuilder.Configurations.Add(new dmNoiKCBMap());
            modelBuilder.Configurations.Add(new dmTyLeDongBHXHMap());
            modelBuilder.Configurations.Add(new HoanVayMap());
            modelBuilder.Configurations.Add(new HoSoVayMuonMap());
            modelBuilder.Configurations.Add(new KhoanVayMap());
            modelBuilder.Configurations.Add(new NhanVienVayMuonMap());
            modelBuilder.Configurations.Add(new nvbhDanhSachDieuChinhChucDanhMap());
            modelBuilder.Configurations.Add(new nvbhDanhSachDieuChinhTangGiamMap());
            modelBuilder.Configurations.Add(new nvbhLaiTruyThuBHMap());
            modelBuilder.Configurations.Add(new nvbhNhanVienBHXHMap());
            modelBuilder.Configurations.Add(new nvbhPhatSinhTrongKyMap());
            modelBuilder.Configurations.Add(new nvbhQuaTrinhBHXHMap());
            modelBuilder.Configurations.Add(new nvbhTongHopCuoiKyMap());
            modelBuilder.Configurations.Add(new TangLaoDongMap());
            modelBuilder.Configurations.Add(new TapTinMap());
            modelBuilder.Configurations.Add(new v_ChucDanhMap());
            modelBuilder.Configurations.Add(new v_nvbhDanhSachDieuChinhTangGiam1Map());
            modelBuilder.Configurations.Add(new v_nvbhNhanVienBHXHMap());
            modelBuilder.Configurations.Add(new v_qtbhxhMap());
        }
    }
}
