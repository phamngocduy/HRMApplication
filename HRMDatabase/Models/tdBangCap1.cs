using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class tdBangCap1
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
		[StringLength(50)]
        public string HoVaTen { get; set; }
		[StringLength(10)]
        public string maLoaiBangCap { get; set; }
		[StringLength(50)]
        public string tenLoaiBangCap { get; set; }
        public Nullable<int> sttLoaiBangCap { get; set; }
        public Nullable<int> idTrinhDo { get; set; }
        public Nullable<byte> doUuTien { get; set; }
		[StringLength(50)]
        public string maTrinhDo { get; set; }
		[StringLength(50)]
        public string tenTrinhDo { get; set; }
        public Nullable<int> sttTrinhDo { get; set; }
		[StringLength(10)]
        public string maDanhHieu { get; set; }
		[StringLength(50)]
        public string tenDanhHieu { get; set; }
        public Nullable<int> sttDanhHieu { get; set; }
        public Nullable<int> idHocVi { get; set; }
		[StringLength(10)]
        public string maHocVi { get; set; }
		[StringLength(50)]
        public string tenHocVi { get; set; }
        public Nullable<int> sttHocVi { get; set; }
        public Nullable<long> stt { get; set; }

    }
}
