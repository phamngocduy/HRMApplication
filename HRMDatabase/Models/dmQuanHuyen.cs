using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmQuanHuyen
    {
        public dmQuanHuyen()
        {
            this.DiaPhuongs = new List<DiaPhuong>();
            this.dmPhuongXas = new List<dmPhuongXa>();
            this.nvDiaChiNhas = new List<nvDiaChiNha>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvSoYeuLyLiches1 = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maQuanHuyen { get; set; }
		[Required]
		[StringLength(50)]
        public string tenQuanHuyen { get; set; }
		[Required]
        public int idTinhThanh { get; set; }

        public virtual ICollection<DiaPhuong> DiaPhuongs { get; set; }
        public virtual ICollection<dmPhuongXa> dmPhuongXas { get; set; }
        public virtual ICollection<nvDiaChiNha> nvDiaChiNhas { get; set; }
		[ForeignKey("idTinhThanh")]
        public virtual dmTinhThanh dmTinhThanh { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches1 { get; set; }
    }
}
