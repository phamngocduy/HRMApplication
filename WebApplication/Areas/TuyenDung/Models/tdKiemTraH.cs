using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class tdKiemTraH
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
        public Nullable<bool> DonXinViec { get; set; }
        public Nullable<bool> SoYeuLyLich { get; set; }
        public Nullable<bool> TheDinhDanh { get; set; }
        public Nullable<bool> SoHoKhau { get; set; }
        public Nullable<bool> GiayKhamSucKhoe { get; set; }
        public Nullable<bool> BangCapBangDiem { get; set; }
        public Nullable<bool> Hinh { get; set; }
        public Nullable<bool> GiayToKhac { get; set; }
        public string GiayToKhac_Note { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
