using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class dmThoiGioLamViec
    {
        public dmThoiGioLamViec()
        {
            this.hdChiTietHDLDs = new List<hdChiTietHDLD>();
        }

		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(100)]
        public string tenThoiGioLamViec { get; set; }

        public virtual ICollection<hdChiTietHDLD> hdChiTietHDLDs { get; set; }
    }
}
