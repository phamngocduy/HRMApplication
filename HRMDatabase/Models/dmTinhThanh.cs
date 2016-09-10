using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmTinhThanh
    {
        public dmTinhThanh()
        {
            this.DiaPhuongs = new List<DiaPhuong>();
            this.dmQuanHuyens = new List<dmQuanHuyen>();
            this.nvDiaChiNhas = new List<nvDiaChiNha>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvSoYeuLyLiches1 = new List<nvSoYeuLyLich>();
            this.nvTheDinhDanhs = new List<nvTheDinhDanh>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maTinhThanh { get; set; }
		[Required]
		[StringLength(50)]
        public string tenTinhThanh { get; set; }

        public virtual ICollection<DiaPhuong> DiaPhuongs { get; set; }
        public virtual ICollection<dmQuanHuyen> dmQuanHuyens { get; set; }
        public virtual ICollection<nvDiaChiNha> nvDiaChiNhas { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches1 { get; set; }
        public virtual ICollection<nvTheDinhDanh> nvTheDinhDanhs { get; set; }
    }
}
