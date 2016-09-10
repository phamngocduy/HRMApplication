using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class TaiNguyen
    {
        public TaiNguyen()
        {
            this.TaiNguyen1 = new List<TaiNguyen>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> idTaiNguyen { get; set; }
		[Required]
		[StringLength(50)]
        public string tenTaiNguyen { get; set; }
		[StringLength(50)]
        public string tepDinhKem { get; set; }
		[Required]
        public bool laThuMuc { get; set; }

        public virtual ICollection<TaiNguyen> TaiNguyen1 { get; set; }
		[ForeignKey("idTaiNguyen")]
        public virtual TaiNguyen chaTaiNguyen { get; set; }
    }
}
