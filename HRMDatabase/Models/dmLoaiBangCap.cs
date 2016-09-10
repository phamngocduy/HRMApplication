using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiBangCap
    {
        public dmLoaiBangCap()
        {
            this.nvBangCaps = new List<nvBangCap>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiBangCap { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiBangCap { get; set; }
        public Nullable<int> idTrinhDo { get; set; }

		[ForeignKey("idTrinhDo")]
        public virtual dmTrinhDo dmTrinhDo { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
    }
}
