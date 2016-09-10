using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class hdNLD
    {
        public hdNLD()
        {
            this.hdChiTietHDLDs = new List<hdChiTietHDLD>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(50)]
        public string NV_id { get; set; }
		[StringLength(50)]
        public string TD_id { get; set; }
		[Required]
        public bool hidden { get; set; }

        public virtual ICollection<hdChiTietHDLD> hdChiTietHDLDs { get; set; }
    }
}
