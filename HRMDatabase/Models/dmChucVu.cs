using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmChucVu
    {
        public dmChucVu()
        {
            this.nvQTLamViecs = new List<nvQTLamViec>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maChucVu { get; set; }
		[Required]
		[StringLength(100)]
        public string tenChucVu { get; set; }

        public virtual ICollection<nvQTLamViec> nvQTLamViecs { get; set; }
    }
}
