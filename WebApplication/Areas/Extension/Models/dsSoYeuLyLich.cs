using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Extension.Databases.Models
{
    public partial class dsSoYeuLyLich
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(50)]
        public string TenGoiKhac { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> GioiTinh_id { get; set; }
        public Nullable<int> NoiSinh_id { get; set; }
        public Nullable<int> QueQuan_id { get; set; }
        public Nullable<int> NoiSinh_TinhThanh_id { get; set; }
        public Nullable<int> NoiSinh_QuanHuyen_id { get; set; }
        public Nullable<int> NoiSinh_PhuongXa_id { get; set; }
		[StringLength(100)]
        public string NoiSinhKhac { get; set; }
        public Nullable<int> QueQuan_TinhThanh_id { get; set; }
        public Nullable<int> QueQuan_PhuongXa_id { get; set; }
        public Nullable<int> QueQuan_QuanHuyen_id { get; set; }
		[StringLength(100)]
        public string QueQuanKhac { get; set; }
        public Nullable<int> DanToc_id { get; set; }
        public Nullable<int> TonGiao_id { get; set; }
        public Nullable<int> QuocTich_id { get; set; }
        public Nullable<int> ChungMinhNhanDan_id { get; set; }
        public Nullable<int> HoKhauThuongTru_id { get; set; }
        public Nullable<int> NoiOHienNay_id { get; set; }
		[StringLength(50)]
        public string NgheNghiep { get; set; }
        public Nullable<System.DateTime> NgayTuyenDung { get; set; }
		[StringLength(50)]
        public string CoQuanTuyenDung { get; set; }
		[StringLength(50)]
        public string ChucVuHienTai { get; set; }
		[StringLength(50)]
        public string CongViecDuocGiao { get; set; }
        public Nullable<int> NgachVienChuc_id { get; set; }
		[StringLength(10)]
        public string MaNgachVienChuc { get; set; }
		[StringLength(50)]
        public string BacLuong_id { get; set; }
        public Nullable<double> HeSoLuong { get; set; }
        public Nullable<System.DateTime> NgayHuongLuong { get; set; }
        public Nullable<double> PhuCapChucVu { get; set; }
        public Nullable<double> PhuCapKhac { get; set; }
        public Nullable<int> TrinhDoHocVan_id { get; set; }
        public Nullable<int> HocHam_id { get; set; }
        public Nullable<int> HocVi_id { get; set; }
        public Nullable<int> LyLuanChinhTri_id { get; set; }
		[StringLength(100)]
        public string TrinhDoNgoaiNgu { get; set; }
		[StringLength(100)]
        public string TrinhDoTinHoc { get; set; }
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
        public Nullable<System.DateTime> NgayVaoDangChinhThuc { get; set; }
        public string HoatDongDoanHoi { get; set; }
        public Nullable<System.DateTime> NgayNhapNgu { get; set; }
        public Nullable<System.DateTime> NgayXuatNgu { get; set; }
        public Nullable<int> QuanHamCaoNhat_id { get; set; }
        public Nullable<int> DanhHieuCaoNhat_id { get; set; }
		[StringLength(50)]
        public string SoTruongCongTac { get; set; }
		[StringLength(50)]
        public string TinhTrangSucKhoe { get; set; }
        public Nullable<int> ChieuCao { get; set; }
        public Nullable<int> CanNang { get; set; }
        public Nullable<int> LaThuongBinhHang_id { get; set; }
        public Nullable<int> GiaDinhChinhSach_id { get; set; }
		[StringLength(20)]
        public string ssBaoHiemXaHoi { get; set; }
		[Required]
        public bool DaNghiHuu { get; set; }
		[StringLength(10)]
        public string MaHS { get; set; }
		[StringLength(10)]
        public string MaNV { get; set; }
		[StringLength(20)]
        public string MaST { get; set; }
		[StringLength(50)]
        public string NoiSinh_tenTinhThanh { get; set; }
		[StringLength(50)]
        public string NoiSinh_tenQuanHuyen { get; set; }
		[StringLength(50)]
        public string NoiSinh_tenPhuongXa { get; set; }
		[StringLength(50)]
        public string tenDanToc { get; set; }
		[StringLength(50)]
        public string tenTonGiao { get; set; }
		[StringLength(100)]
        public string tenQuocTich { get; set; }
		[StringLength(50)]
        public string tenHocHam { get; set; }
		[StringLength(50)]
        public string tenHocVi { get; set; }
		[StringLength(50)]
        public string tenTrinhDo { get; set; }
		[StringLength(50)]
        public string tenTrinhDoHocVan { get; set; }
		[StringLength(50)]
        public string tenTrinhDoChinhTri { get; set; }
		[StringLength(50)]
        public string tenQuanHamQuanDoi { get; set; }
		[StringLength(50)]
        public string tenDanhHieuPhongTang { get; set; }
		[StringLength(50)]
        public string tenHangThuongBinh { get; set; }
		[StringLength(50)]
        public string tenGiaDinhChinhSach { get; set; }
        public Nullable<System.DateTime> ngayNghiViec { get; set; }
		[StringLength(20)]
        public string qtlvSoQDNghiViec { get; set; }

    }
}
