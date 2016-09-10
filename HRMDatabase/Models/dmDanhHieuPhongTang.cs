using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmDanhHieuPhongTang
    {
        public dmDanhHieuPhongTang()
        {
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maDanhHieuPhongTang { get; set; }
		[Required]
		[StringLength(50)]
        public string tenDanhHieuPhongTang { get; set; }

        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
    }
}
