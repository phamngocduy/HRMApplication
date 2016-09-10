using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmNgachVienChuc
    {
        public dmNgachVienChuc()
        {
            this.nvHeSoLuongs = new List<nvHeSoLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maNgachVienChuc { get; set; }
		[Required]
		[StringLength(60)]
        public string tenNgachVienChuc { get; set; }
		[Required]
        public int nhomNgachVienChuc { get; set; }

		[ForeignKey("nhomNgachVienChuc")]
        public virtual dmNhomNgachVienChuc dmNhomNgachVienChuc { get; set; }
        public virtual ICollection<nvHeSoLuong> nvHeSoLuongs { get; set; }
    }
}
