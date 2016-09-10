using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmKhoaGiangDay
    {
        public dmKhoaGiangDay()
        {
            this.nvKhoaGiangDays = new List<nvKhoaGiangDay>();
            this.nvTTThongKes = new List<nvTTThongKe>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maKhoaGiangDay { get; set; }
		[Required]
		[StringLength(50)]
        public string tenKhoaGiangDay { get; set; }

        public virtual ICollection<nvKhoaGiangDay> nvKhoaGiangDays { get; set; }
        public virtual ICollection<nvTTThongKe> nvTTThongKes { get; set; }
    }
}
