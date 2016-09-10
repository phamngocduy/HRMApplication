using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using HRM.Databases.Models;
using HRM.Databases.Models.Mapping;
namespace HRM.Databases.Model1
{
    public partial class HRMDBEntities : DbContext
    {
        static HRMDBEntities()
        {
            Database.SetInitializer<HRMDBEntities>(null);
        }

        public HRMDBEntities()
            : base("Name=HRMDBEntities")
        {
        }

        public DbSet<bcKhoaGiangDay> bcKhoaGiangDay { get; set; }
        public DbSet<BoiDuongChuyenMon> BoiDuongChuyenMon { get; set; }
        public DbSet<BuoiTapHuan> BuoiTapHuan { get; set; }
        public DbSet<ChungChi> ChungChi { get; set; }
        public DbSet<CTNganHan> CTNganHan { get; set; }
        public DbSet<DanhHieu> DanhHieu { get; set; }
        public DbSet<DiaPhuong> DiaPhuong { get; set; }
        public DbSet<dmBangLuong> dmBangLuong { get; set; }
        public DbSet<dmCheDoHoc> dmCheDoHoc { get; set; }
        public DbSet<dmChucDanh> dmChucDanh { get; set; }
        public DbSet<dmChucDanhChuyenMon> dmChucDanhChuyenMon { get; set; }
        public DbSet<dmChucDanhGiangVien> dmChucDanhGiangVien { get; set; }
        public DbSet<dmChucVu> dmChucVu { get; set; }
        public DbSet<dmChucVuDoanThe> dmChucVuDoanThe { get; set; }
        public DbSet<dmChuyenNganh> dmChuyenNganh { get; set; }
        public DbSet<dmCongTacDoanThe> dmCongTacDoanThe { get; set; }
        public DbSet<dmDanhHieu> dmDanhHieu { get; set; }
        public DbSet<dmDanhHieuPhongTang> dmDanhHieuPhongTang { get; set; }
        public DbSet<dmDanToc> dmDanToc { get; set; }
        public DbSet<dmDonVi> dmDonVi { get; set; }
        public DbSet<dmGiaDinhChinhSach> dmGiaDinhChinhSach { get; set; }
        public DbSet<dmGioiTinh> dmGioiTinh { get; set; }
        public DbSet<dmHangThuongBinh> dmHangThuongBinh { get; set; }
        public DbSet<dmHienTrangDiHoc> dmHienTrangDiHoc { get; set; }
        public DbSet<dmHinhThucKhenThuong> dmHinhThucKhenThuong { get; set; }
        public DbSet<dmHinhThucKyLuat> dmHinhThucKyLuat { get; set; }
        public DbSet<dmHocHam> dmHocHam { get; set; }
        public DbSet<dmHocVi> dmHocVi { get; set; }
        public DbSet<dmKhoaGiangDay> dmKhoaGiangDay { get; set; }
        public DbSet<dmLoaiBangCap> dmLoaiBangCap { get; set; }
        public DbSet<dmLoaiBaoLuuHSL> dmLoaiBaoLuuHSL { get; set; }
        public DbSet<dmLoaiChungChi> dmLoaiChungChi { get; set; }
        public DbSet<dmLoaiCongTac> dmLoaiCongTac { get; set; }
        public DbSet<dmLoaiHinhDaoTao> dmLoaiHinhDaoTao { get; set; }
        public DbSet<dmLoaiHocTap> dmLoaiHocTap { get; set; }
        public DbSet<dmLoaiKhoaHoc> dmLoaiKhoaHoc { get; set; }
        public DbSet<dmLoaiNghiNganHan> dmLoaiNghiNganHan { get; set; }
        public DbSet<dmLoaiQuyetDinh> dmLoaiQuyetDinh { get; set; }
        public DbSet<dmLoaiTheDinhDanh> dmLoaiTheDinhDanh { get; set; }
        public DbSet<dmMoiQuanHe> dmMoiQuanHe { get; set; }
        public DbSet<dmNgachVienChuc> dmNgachVienChuc { get; set; }
        public DbSet<dmNganhGiangDay> dmNganhGiangDay { get; set; }
        public DbSet<dmNgheNghiep> dmNgheNghiep { get; set; }
        public DbSet<dmNhomNgachVienChuc> dmNhomNgachVienChuc { get; set; }
        public DbSet<dmNhomNganh> dmNhomNganh { get; set; }
        public DbSet<dmNoiHoc> dmNoiHoc { get; set; }
        public DbSet<dmPhanLoaiCBGVNV> dmPhanLoaiCBGVNV { get; set; }
        public DbSet<dmPhuongXa> dmPhuongXa { get; set; }
        public DbSet<dmQuanHamQuanDoi> dmQuanHamQuanDoi { get; set; }
        public DbSet<dmQuanHuyen> dmQuanHuyen { get; set; }
        public DbSet<dmQuocGia> dmQuocGia { get; set; }
        public DbSet<dmQuyetDinh> dmQuyetDinh { get; set; }
        public DbSet<dmThanhPhanGiaDinh> dmThanhPhanGiaDinh { get; set; }
        public DbSet<dmTinhThanh> dmTinhThanh { get; set; }
        public DbSet<dmTonGiao> dmTonGiao { get; set; }
        public DbSet<dmTrinhDo> dmTrinhDo { get; set; }
        public DbSet<dmTrinhDoChinhTri> dmTrinhDoChinhTri { get; set; }
        public DbSet<dmTrinhDoHocVan> dmTrinhDoHocVan { get; set; }
        public DbSet<dmTrinhDoNgoaiNgu> dmTrinhDoNgoaiNgu { get; set; }
        public DbSet<dmTrinhDoQuanLy> dmTrinhDoQuanLy { get; set; }
        public DbSet<dmTrinhDoTinHoc> dmTrinhDoTinHoc { get; set; }
        public DbSet<dmXepLoaiTotNghiep> dmXepLoaiTotNghiep { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<nvBangCap> nvBangCap { get; set; }
        public DbSet<nvChucDanhGiangVien> nvChucDanhGiangVien { get; set; }
        public DbSet<nvCTDoanThe> nvCTDoanThe { get; set; }
        public DbSet<nvCTDoanTheTruoc> nvCTDoanTheTruoc { get; set; }
        public DbSet<nvCTNganHan> nvCTNganHan { get; set; }
        public DbSet<nvDiaChiNha> nvDiaChiNha { get; set; }
        public DbSet<nvGiuBacLuong> nvGiuBacLuong { get; set; }
        public DbSet<nvHeSoLuong> nvHeSoLuong { get; set; }
        public DbSet<nvHocHam> nvHocHam { get; set; }
        public DbSet<nvKhoaGiangDay> nvKhoaGiangDay { get; set; }
        public DbSet<nvLuongKhoan> nvLuongKhoan { get; set; }
        public DbSet<nvNganhGiangDay> nvNganhGiangDay { get; set; }
        public DbSet<nvQHGiaDinh> nvQHGiaDinh { get; set; }
        public DbSet<nvQLHoSoHSL> nvQLHoSoHSL { get; set; }
        public DbSet<nvQLTapSu> nvQLTapSu { get; set; }
        public DbSet<nvQLThuViec> nvQLThuViec { get; set; }
        public DbSet<nvQTChungChi> nvQTChungChi { get; set; }
        public DbSet<nvQTHocTap> nvQTHocTap { get; set; }
        public DbSet<nvQTKiemNhiem> nvQTKiemNhiem { get; set; }
        public DbSet<nvQTLamViec> nvQTLamViec { get; set; }
        public DbSet<nvQTLamViecTruoc> nvQTLamViecTruoc { get; set; }
        public DbSet<nvQTNghiNganHan> nvQTNghiNganHan { get; set; }
        public DbSet<nvSoYeuLyLich> nvSoYeuLyLich { get; set; }
        public DbSet<nvTapHuan> nvTapHuan { get; set; }
        public DbSet<nvTheDinhDanh> nvTheDinhDanh { get; set; }
        public DbSet<nvTrangThaiLuong> nvTrangThaiLuong { get; set; }
        public DbSet<nvTTKhenThuong> nvTTKhenThuong { get; set; }
        public DbSet<nvTTKhenThuongTruoc> nvTTKhenThuongTruoc { get; set; }
        public DbSet<nvTTKyLuat> nvTTKyLuat { get; set; }
        public DbSet<nvTTKyLuatTruoc> nvTTKyLuatTruoc { get; set; }
        public DbSet<nvTTMoRong> nvTTMoRong { get; set; }
        public DbSet<nvTTThongKe> nvTTThongKe { get; set; }
        public DbSet<QuaTrinhHoc> QuaTrinhHoc { get; set; }
        public DbSet<sysdiagram> sysdiagram { get; set; }
        public DbSet<TaiNguyen> TaiNguyen { get; set; }
        public DbSet<TapHuan> TapHuan { get; set; }
        public DbSet<adHeSoLuong> adHeSoLuong { get; set; }
        public DbSet<dsBangCap> dsBangCap { get; set; }
        public DbSet<dsChucDanhGiangVien> dsChucDanhGiangVien { get; set; }
        public DbSet<dsChucDanhGiangVien1> dsChucDanhGiangVien1 { get; set; }
        public DbSet<dsCTDoanThe> dsCTDoanThe { get; set; }
        public DbSet<dsCTDoanTheTruoc> dsCTDoanTheTruoc { get; set; }
        public DbSet<dsDiaChiNha> dsDiaChiNha { get; set; }
        public DbSet<dsDienBienLuong> dsDienBienLuong { get; set; }
        public DbSet<dsGiuBacLuong> dsGiuBacLuong { get; set; }
        public DbSet<dsHeSoLuong> dsHeSoLuong { get; set; }
        public DbSet<dsHocHam> dsHocHam { get; set; }
        public DbSet<dsHocHam1> dsHocHam1 { get; set; }
        public DbSet<dsNganhGiangDay> dsNganhGiangDay { get; set; }
        public DbSet<dsNhanVien> dsNhanVien { get; set; }
        public DbSet<dsNhanVienMoi> dsNhanVienMoi { get; set; }
        public DbSet<dsQHGiaDinh> dsQHGiaDinh { get; set; }
        public DbSet<dsQLHoSoHSL> dsQLHoSoHSL { get; set; }
        public DbSet<dsQLTapSu> dsQLTapSu { get; set; }
        public DbSet<dsQLThuViec> dsQLThuViec { get; set; }
        public DbSet<dsQTKiemNhiem> dsQTKiemNhiem { get; set; }
        public DbSet<dsQTLamNghiViec> dsQTLamNghiViec { get; set; }
        public DbSet<dsSoYeuLyLich> dsSoYeuLyLich { get; set; }
        public DbSet<dsTheDinhDanh> dsTheDinhDanh { get; set; }
        public DbSet<dsTTKhenThuong> dsTTKhenThuong { get; set; }
        public DbSet<dsTTKyLuat> dsTTKyLuat { get; set; }
        public DbSet<hvBangCap1> hvBangCap1 { get; set; }
        public DbSet<tdBangCap1> tdBangCap1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new bcKhoaGiangDayMap());
            modelBuilder.Configurations.Add(new BoiDuongChuyenMonMap());
            modelBuilder.Configurations.Add(new BuoiTapHuanMap());
            modelBuilder.Configurations.Add(new ChungChiMap());
            modelBuilder.Configurations.Add(new CTNganHanMap());
            modelBuilder.Configurations.Add(new DanhHieuMap());
            modelBuilder.Configurations.Add(new DiaPhuongMap());
            modelBuilder.Configurations.Add(new dmBangLuongMap());
            modelBuilder.Configurations.Add(new dmCheDoHocMap());
            modelBuilder.Configurations.Add(new dmChucDanhMap());
            modelBuilder.Configurations.Add(new dmChucDanhChuyenMonMap());
            modelBuilder.Configurations.Add(new dmChucDanhGiangVienMap());
            modelBuilder.Configurations.Add(new dmChucVuMap());
            modelBuilder.Configurations.Add(new dmChucVuDoanTheMap());
            modelBuilder.Configurations.Add(new dmChuyenNganhMap());
            modelBuilder.Configurations.Add(new dmCongTacDoanTheMap());
            modelBuilder.Configurations.Add(new dmDanhHieuMap());
            modelBuilder.Configurations.Add(new dmDanhHieuPhongTangMap());
            modelBuilder.Configurations.Add(new dmDanTocMap());
            modelBuilder.Configurations.Add(new dmDonViMap());
            modelBuilder.Configurations.Add(new dmGiaDinhChinhSachMap());
            modelBuilder.Configurations.Add(new dmGioiTinhMap());
            modelBuilder.Configurations.Add(new dmHangThuongBinhMap());
            modelBuilder.Configurations.Add(new dmHienTrangDiHocMap());
            modelBuilder.Configurations.Add(new dmHinhThucKhenThuongMap());
            modelBuilder.Configurations.Add(new dmHinhThucKyLuatMap());
            modelBuilder.Configurations.Add(new dmHocHamMap());
            modelBuilder.Configurations.Add(new dmHocViMap());
            modelBuilder.Configurations.Add(new dmKhoaGiangDayMap());
            modelBuilder.Configurations.Add(new dmLoaiBangCapMap());
            modelBuilder.Configurations.Add(new dmLoaiBaoLuuHSLMap());
            modelBuilder.Configurations.Add(new dmLoaiChungChiMap());
            modelBuilder.Configurations.Add(new dmLoaiCongTacMap());
            modelBuilder.Configurations.Add(new dmLoaiHinhDaoTaoMap());
            modelBuilder.Configurations.Add(new dmLoaiHocTapMap());
            modelBuilder.Configurations.Add(new dmLoaiKhoaHocMap());
            modelBuilder.Configurations.Add(new dmLoaiNghiNganHanMap());
            modelBuilder.Configurations.Add(new dmLoaiQuyetDinhMap());
            modelBuilder.Configurations.Add(new dmLoaiTheDinhDanhMap());
            modelBuilder.Configurations.Add(new dmMoiQuanHeMap());
            modelBuilder.Configurations.Add(new dmNgachVienChucMap());
            modelBuilder.Configurations.Add(new dmNganhGiangDayMap());
            modelBuilder.Configurations.Add(new dmNgheNghiepMap());
            modelBuilder.Configurations.Add(new dmNhomNgachVienChucMap());
            modelBuilder.Configurations.Add(new dmNhomNganhMap());
            modelBuilder.Configurations.Add(new dmNoiHocMap());
            modelBuilder.Configurations.Add(new dmPhanLoaiCBGVNVMap());
            modelBuilder.Configurations.Add(new dmPhuongXaMap());
            modelBuilder.Configurations.Add(new dmQuanHamQuanDoiMap());
            modelBuilder.Configurations.Add(new dmQuanHuyenMap());
            modelBuilder.Configurations.Add(new dmQuocGiaMap());
            modelBuilder.Configurations.Add(new dmQuyetDinhMap());
            modelBuilder.Configurations.Add(new dmThanhPhanGiaDinhMap());
            modelBuilder.Configurations.Add(new dmTinhThanhMap());
            modelBuilder.Configurations.Add(new dmTonGiaoMap());
            modelBuilder.Configurations.Add(new dmTrinhDoMap());
            modelBuilder.Configurations.Add(new dmTrinhDoChinhTriMap());
            modelBuilder.Configurations.Add(new dmTrinhDoHocVanMap());
            modelBuilder.Configurations.Add(new dmTrinhDoNgoaiNguMap());
            modelBuilder.Configurations.Add(new dmTrinhDoQuanLyMap());
            modelBuilder.Configurations.Add(new dmTrinhDoTinHocMap());
            modelBuilder.Configurations.Add(new dmXepLoaiTotNghiepMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new nvBangCapMap());
            modelBuilder.Configurations.Add(new nvChucDanhGiangVienMap());
            modelBuilder.Configurations.Add(new nvCTDoanTheMap());
            modelBuilder.Configurations.Add(new nvCTDoanTheTruocMap());
            modelBuilder.Configurations.Add(new nvCTNganHanMap());
            modelBuilder.Configurations.Add(new nvDiaChiNhaMap());
            modelBuilder.Configurations.Add(new nvGiuBacLuongMap());
            modelBuilder.Configurations.Add(new nvHeSoLuongMap());
            modelBuilder.Configurations.Add(new nvHocHamMap());
            modelBuilder.Configurations.Add(new nvKhoaGiangDayMap());
            modelBuilder.Configurations.Add(new nvLuongKhoanMap());
            modelBuilder.Configurations.Add(new nvNganhGiangDayMap());
            modelBuilder.Configurations.Add(new nvQHGiaDinhMap());
            modelBuilder.Configurations.Add(new nvQLHoSoHSLMap());
            modelBuilder.Configurations.Add(new nvQLTapSuMap());
            modelBuilder.Configurations.Add(new nvQLThuViecMap());
            modelBuilder.Configurations.Add(new nvQTChungChiMap());
            modelBuilder.Configurations.Add(new nvQTHocTapMap());
            modelBuilder.Configurations.Add(new nvQTKiemNhiemMap());
            modelBuilder.Configurations.Add(new nvQTLamViecMap());
            modelBuilder.Configurations.Add(new nvQTLamViecTruocMap());
            modelBuilder.Configurations.Add(new nvQTNghiNganHanMap());
            modelBuilder.Configurations.Add(new nvSoYeuLyLichMap());
            modelBuilder.Configurations.Add(new nvTapHuanMap());
            modelBuilder.Configurations.Add(new nvTheDinhDanhMap());
            modelBuilder.Configurations.Add(new nvTrangThaiLuongMap());
            modelBuilder.Configurations.Add(new nvTTKhenThuongMap());
            modelBuilder.Configurations.Add(new nvTTKhenThuongTruocMap());
            modelBuilder.Configurations.Add(new nvTTKyLuatMap());
            modelBuilder.Configurations.Add(new nvTTKyLuatTruocMap());
            modelBuilder.Configurations.Add(new nvTTMoRongMap());
            modelBuilder.Configurations.Add(new nvTTThongKeMap());
            modelBuilder.Configurations.Add(new QuaTrinhHocMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TaiNguyenMap());
            modelBuilder.Configurations.Add(new TapHuanMap());
            modelBuilder.Configurations.Add(new adHeSoLuongMap());
            modelBuilder.Configurations.Add(new dsBangCapMap());
            modelBuilder.Configurations.Add(new dsChucDanhGiangVienMap());
            modelBuilder.Configurations.Add(new dsChucDanhGiangVien1Map());
            modelBuilder.Configurations.Add(new dsCTDoanTheMap());
            modelBuilder.Configurations.Add(new dsCTDoanTheTruocMap());
            modelBuilder.Configurations.Add(new dsDiaChiNhaMap());
            modelBuilder.Configurations.Add(new dsDienBienLuongMap());
            modelBuilder.Configurations.Add(new dsGiuBacLuongMap());
            modelBuilder.Configurations.Add(new dsHeSoLuongMap());
            modelBuilder.Configurations.Add(new dsHocHamMap());
            modelBuilder.Configurations.Add(new dsHocHam1Map());
            modelBuilder.Configurations.Add(new dsNganhGiangDayMap());
            modelBuilder.Configurations.Add(new dsNhanVienMap());
            modelBuilder.Configurations.Add(new dsNhanVienMoiMap());
            modelBuilder.Configurations.Add(new dsQHGiaDinhMap());
            modelBuilder.Configurations.Add(new dsQLHoSoHSLMap());
            modelBuilder.Configurations.Add(new dsQLTapSuMap());
            modelBuilder.Configurations.Add(new dsQLThuViecMap());
            modelBuilder.Configurations.Add(new dsQTKiemNhiemMap());
            modelBuilder.Configurations.Add(new dsQTLamNghiViecMap());
            modelBuilder.Configurations.Add(new dsSoYeuLyLichMap());
            modelBuilder.Configurations.Add(new dsTheDinhDanhMap());
            modelBuilder.Configurations.Add(new dsTTKhenThuongMap());
            modelBuilder.Configurations.Add(new dsTTKyLuatMap());
            modelBuilder.Configurations.Add(new hvBangCap1Map());
            modelBuilder.Configurations.Add(new tdBangCap1Map());
        }
    }
}
