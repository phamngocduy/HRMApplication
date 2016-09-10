using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class dmLoaiHopDong
    {
        public dmLoaiHopDong()
        {
            this.hdChiTietHDLDs = new List<hdChiTietHDLD>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiHD { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiHD { get; set; }

        public virtual ICollection<hdChiTietHDLD> hdChiTietHDLDs { get; set; }
    }
}
