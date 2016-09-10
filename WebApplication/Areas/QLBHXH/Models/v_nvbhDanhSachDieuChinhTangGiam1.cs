using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class v_nvbhDanhSachDieuChinhTangGiam1
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int MoiNhat { get; set; }
		[Required]
        public bool XacNhan { get; set; }
		[Required]
        public bool KhongTraThe { get; set; }
		[StringLength(5)]
        public string idLoaiTangGiam { get; set; }
		[Required]
        public int idLoaiDieuChinh { get; set; }
        public Nullable<int> idnvbhNhanVienBHXH { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
		[StringLength(50)]
        public string ChucVuCongViec { get; set; }
        public Nullable<long> TienLuongMDC { get; set; }
        public Nullable<long> PCChucVuMDC { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDC { get; set; }
        public Nullable<long> PCThamNienNgheMDC { get; set; }
        public Nullable<long> PCKhacMDC { get; set; }
        public Nullable<long> TienLuongMDM { get; set; }
        public Nullable<long> PCChucVuMDM { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDM { get; set; }
        public Nullable<long> PCThamNienNgheMDM { get; set; }
        public Nullable<long> PCKhacMDM { get; set; }
		[Required]
        public System.DateTime TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public Nullable<double> TyLeDong { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<bool> TGBHTN { get; set; }
		[StringLength(200)]
        public string LoaiDieuChinh { get; set; }
		[StringLength(100)]
        public string HoVaTen { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<double> tldong { get; set; }
		[StringLength(50)]
        public string tenChucDanhChuyenMon { get; set; }

    }
}
