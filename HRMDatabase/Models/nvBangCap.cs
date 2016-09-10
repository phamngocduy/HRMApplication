using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvBangCap
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int LoaiBangCap_id { get; set; }
        public Nullable<int> DanhHieu_id { get; set; }
		[StringLength(50)]
        public string TenTruong { get; set; }
		[Required]
        public int ChuyenNganh_id { get; set; }
        public string ChuyenNganh { get; set; }
		[Required]
        public int LoaiHinhDaoTao_id { get; set; }
        public Nullable<System.DateTime> NgayTN { get; set; }
        public Nullable<int> XepLoaiTotNghiep_id { get; set; }
		[Required]
        public bool ChuyenNganhChinh { get; set; }
        public string GhiChu { get; set; }
		[Required]
        public int NoiHoc_id { get; set; }
		[Required]
        public int QuocGia_id { get; set; }
		[Required]
        public bool DanhHieuChinh { get; set; }
		[Required]
        public bool Xoa { get; set; }
        public Nullable<bool> SauKhiVeTruong { get; set; }
        public Nullable<int> HoTro { get; set; }

		[ForeignKey("ChuyenNganh_id")]
        public virtual dmChuyenNganh dmChuyenNganh { get; set; }
		[ForeignKey("DanhHieu_id")]
        public virtual dmDanhHieu dmDanhHieu { get; set; }
		[ForeignKey("LoaiBangCap_id")]
        public virtual dmLoaiBangCap dmLoaiBangCap { get; set; }
		[ForeignKey("LoaiHinhDaoTao_id")]
        public virtual dmLoaiHinhDaoTao dmLoaiHinhDaoTao { get; set; }
		[ForeignKey("NoiHoc_id")]
        public virtual dmNoiHoc dmNoiHoc { get; set; }
		[ForeignKey("QuocGia_id")]
        public virtual dmQuocGia dmQuocGia { get; set; }
		[ForeignKey("XepLoaiTotNghiep_id")]
        public virtual dmXepLoaiTotNghiep dmXepLoaiTotNghiep { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
		[ForeignKey("HoTro")]
        public virtual nvQTHocTap nvKinhPhiBangCap { get; set; }
    }
}
