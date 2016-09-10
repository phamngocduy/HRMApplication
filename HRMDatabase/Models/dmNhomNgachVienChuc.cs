using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmNhomNgachVienChuc
    {
        public dmNhomNgachVienChuc()
        {
            this.dmBangLuongs = new List<dmBangLuong>();
            this.dmNgachVienChucs = new List<dmNgachVienChuc>();
            this.nvHeSoLuongs = new List<nvHeSoLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
        public Nullable<int> bangLuong { get; set; }
		[StringLength(10)]
        public string maNhomNgachVienChuc { get; set; }
		[Required]
		[StringLength(50)]
        public string tenNhomNgachVienChuc { get; set; }

        public virtual ICollection<dmBangLuong> dmBangLuongs { get; set; }
        public virtual ICollection<dmNgachVienChuc> dmNgachVienChucs { get; set; }
        public virtual ICollection<nvHeSoLuong> nvHeSoLuongs { get; set; }
    }
}
