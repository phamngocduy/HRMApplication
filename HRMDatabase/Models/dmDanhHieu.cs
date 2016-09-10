using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmDanhHieu
    {
        public dmDanhHieu()
        {
            this.DanhHieux = new List<DanhHieu>();
            this.nvBangCaps = new List<nvBangCap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maDanhHieu { get; set; }
		[Required]
		[StringLength(50)]
        public string tenDanhHieu { get; set; }
        public Nullable<int> idHocVi { get; set; }

        public virtual ICollection<DanhHieu> DanhHieux { get; set; }
		[ForeignKey("idHocVi")]
        public virtual dmHocVi dmHocVi { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
    }
}
