using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class TapHuan
    {
        public TapHuan()
        {
            this.BuoiTapHuans = new List<BuoiTapHuan>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(150)]
        public string TenKhoaTH { get; set; }
		[Required]
		[StringLength(150)]
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[StringLength(50)]
        public string SoLuotThamGia { get; set; }
		[StringLength(50)]
        public string KinhPhi { get; set; }
		[StringLength(150)]
        public string DiaDiem { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }

        public virtual ICollection<BuoiTapHuan> BuoiTapHuans { get; set; }
    }
}
