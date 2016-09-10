using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmTrinhDo
    {
        public dmTrinhDo()
        {
            this.dmHocVis = new List<dmHocVi>();
            this.dmLoaiBangCaps = new List<dmLoaiBangCap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(50)]
        public string maTrinhDo { get; set; }
		[StringLength(50)]
        public string tenTrinhDo { get; set; }
		[Required]
        public byte doUuTien { get; set; }

        public virtual ICollection<dmHocVi> dmHocVis { get; set; }
        public virtual ICollection<dmLoaiBangCap> dmLoaiBangCaps { get; set; }
    }
}
