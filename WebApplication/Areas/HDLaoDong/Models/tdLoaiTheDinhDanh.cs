using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdLoaiTheDinhDanh
    {
        public tdLoaiTheDinhDanh()
        {
            this.tdTheDinhDanhs = new List<tdTheDinhDanh>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(50)]
        public string LoaiTheDinhDanh { get; set; }

        public virtual ICollection<tdTheDinhDanh> tdTheDinhDanhs { get; set; }
    }
}
