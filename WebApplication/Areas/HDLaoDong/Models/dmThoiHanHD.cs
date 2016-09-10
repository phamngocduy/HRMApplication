using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class dmThoiHanHD
    {
        public dmThoiHanHD()
        {
            this.hdChiTietHDLDs = new List<hdChiTietHDLD>();
        }

		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(100)]
        public string tenThoiHanHD { get; set; }
        public Nullable<int> valThoiHanHD { get; set; }
        public Nullable<bool> Duoi { get; set; }
		[StringLength(50)]
        public string loaiHopDong { get; set; }

        public virtual ICollection<hdChiTietHDLD> hdChiTietHDLDs { get; set; }
    }
}
