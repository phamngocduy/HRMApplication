using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class BuoiTapHuan
    {
		[Required]
        public int Id { get; set; }
		[Required]
        public int TapHuan_id { get; set; }
        public Nullable<System.DateTime> NgayTapHuan { get; set; }
        public Nullable<int> BuoiTapHuan1 { get; set; }
		[StringLength(50)]
        public string ThoiGianBatDau { get; set; }
		[StringLength(50)]
        public string ThoiGianKetThuc { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }

		[ForeignKey("TapHuan_id")]
        public virtual TapHuan TapHuan { get; set; }
    }
}
