using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
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
        public bool Chuyennganhchinh { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }
		[Required]
        public int NoiHoc_id { get; set; }
		[Required]
        public int QuocGia_id { get; set; }
		[Required]
        public bool DanhHieuChinh { get; set; }
        public Nullable<bool> Xoa { get; set; }
        public Nullable<bool> SauKhiVeTruong { get; set; }
        public Nullable<int> HoTro { get; set; }

		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
