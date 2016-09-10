using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiHocTap
    {
        public dmLoaiHocTap()
        {
            this.nvQTHocTaps = new List<nvQTHocTap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(50)]
        public string maLoaiHocTap { get; set; }
        public string tenLoaiHocTap { get; set; }

        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
    }
}
