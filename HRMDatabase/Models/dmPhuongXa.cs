using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmPhuongXa
    {
        public dmPhuongXa()
        {
            this.DiaPhuongs = new List<DiaPhuong>();
            this.nvDiaChiNhas = new List<nvDiaChiNha>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvSoYeuLyLiches1 = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maPhuongXa { get; set; }
		[Required]
		[StringLength(50)]
        public string tenPhuongXa { get; set; }
		[Required]
        public int idQuanHuyen { get; set; }

        public virtual ICollection<DiaPhuong> DiaPhuongs { get; set; }
        public virtual ICollection<nvDiaChiNha> nvDiaChiNhas { get; set; }
		[ForeignKey("idQuanHuyen")]
        public virtual dmQuanHuyen dmQuanHuyen { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches1 { get; set; }
    }
}
