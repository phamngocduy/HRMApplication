using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQLHoSoHSL
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int HSL_id { get; set; }
        public Nullable<System.DateTime> BanTuNhanXet { get; set; }
        public Nullable<System.DateTime> BienBanHopDonVi { get; set; }
        public Nullable<System.DateTime> DeXuatTruongDonVi { get; set; }
		[Required]
        public bool HoanThanh { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
		[Required]
        public double HeSoLuong { get; set; }
		[Required]
        public int PhuCap { get; set; }
		[Required]
        public int ThoiGianGiuBac { get; set; }

		[ForeignKey("HSL_id")]
        public virtual nvHeSoLuong nvHeSoLuong { get; set; }
    }
}
