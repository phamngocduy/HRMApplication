using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class DiaPhuong
    {
        public DiaPhuong()
        {
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvSoYeuLyLiches1 = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> PhuongXa_id { get; set; }
        public Nullable<int> QuanHuyen_id { get; set; }
        public Nullable<int> TinhThanh_id { get; set; }

		[ForeignKey("PhuongXa_id")]
        public virtual dmPhuongXa dmPhuongXa { get; set; }
		[ForeignKey("QuanHuyen_id")]
        public virtual dmQuanHuyen dmQuanHuyen { get; set; }
		[ForeignKey("TinhThanh_id")]
        public virtual dmTinhThanh dmTinhThanh { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches1 { get; set; }
    }
}
