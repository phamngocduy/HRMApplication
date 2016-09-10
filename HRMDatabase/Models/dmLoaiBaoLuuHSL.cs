using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiBaoLuuHSL
    {
        public dmLoaiBaoLuuHSL()
        {
            this.nvGiuBacLuongs = new List<nvGiuBacLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiBaoLuuHSL { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiBaoLuuHSL { get; set; }

        public virtual ICollection<nvGiuBacLuong> nvGiuBacLuongs { get; set; }
    }
}
