using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiTheDinhDanh
    {
        public dmLoaiTheDinhDanh()
        {
            this.nvTheDinhDanhs = new List<nvTheDinhDanh>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiTheDinhDanh { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiTheDinhDanh { get; set; }

        public virtual ICollection<nvTheDinhDanh> nvTheDinhDanhs { get; set; }
    }
}
