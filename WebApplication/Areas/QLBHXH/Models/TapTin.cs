using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class TapTin
    {
        public TapTin()
        {
            this.TapTin1 = new List<TapTin>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> idTapTin { get; set; }
		[StringLength(50)]
        public string tenThuMuc { get; set; }
		[Required]
		[StringLength(100)]
        public string tepDinhKem { get; set; }
		[Required]
        public bool laThuMuc { get; set; }
		[Required]
		[StringLength(100)]
        public string tengiayto { get; set; }

        public virtual ICollection<TapTin> TapTin1 { get; set; }
		[ForeignKey("idTapTin")]
        public virtual TapTin Upload { get; set; }
    }
}
