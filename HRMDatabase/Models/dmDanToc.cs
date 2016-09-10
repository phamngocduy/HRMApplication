using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmDanToc
    {
        public dmDanToc()
        {
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[Required]
		[StringLength(50)]
        public string tenDanToc { get; set; }
		[Required]
        public bool laThieuSo { get; set; }

        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
    }
}
