using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhDanhSachDieuChinhTangGiam
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
		[Required]
        public System.DateTime TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
		[StringLength(50)]
        public string ChucVuCongViec { get; set; }
        public Nullable<long> TienLuongMDC { get; set; }
        public Nullable<long> TienLuongMDM { get; set; }
        public Nullable<long> PCChucVuMDC { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDC { get; set; }
        public Nullable<long> PCThamNienNgheMDC { get; set; }
        public Nullable<long> PCKhacMDC { get; set; }
        public Nullable<long> PCChucVuMDM { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDM { get; set; }
        public Nullable<long> PCThamNienNgheMDM { get; set; }
        public Nullable<long> PCKhacMDM { get; set; }
        public Nullable<double> TyLeDong { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
		[StringLength(200)]
        public string Tang { get; set; }
		[StringLength(200)]
        public string CVCu { get; set; }
		[StringLength(200)]
        public string CVMoi { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<bool> TGBHTN { get; set; }
        public Nullable<long> TienLuong { get; set; }
        public Nullable<double> HSL { get; set; }
        public Nullable<long> MLTTV { get; set; }
        public Nullable<long> MLTTC { get; set; }
        public Nullable<double> TLBHXH { get; set; }
        public Nullable<double> TLBHTN { get; set; }
        public Nullable<double> TLBHYT { get; set; }
        public Nullable<int> QTID { get; set; }

		[ForeignKey("idLoaiDieuChinh")]
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
    }
}
