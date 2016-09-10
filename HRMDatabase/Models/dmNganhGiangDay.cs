using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmNganhGiangDay
    {
        public dmNganhGiangDay()
        {
            this.nvNganhGiangDays = new List<nvNganhGiangDay>();
            this.nvTTThongKes = new List<nvTTThongKe>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maNganhGiangDay { get; set; }
		[Required]
		[StringLength(50)]
        public string tenNganhGiangDay { get; set; }

        public virtual ICollection<nvNganhGiangDay> nvNganhGiangDays { get; set; }
        public virtual ICollection<nvTTThongKe> nvTTThongKes { get; set; }
    }
}
