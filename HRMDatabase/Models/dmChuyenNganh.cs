using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmChuyenNganh
    {
        public dmChuyenNganh()
        {
            this.nvBangCaps = new List<nvBangCap>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(50)]
        public string maChuyenNganh { get; set; }
		[Required]
        public string tenChuyenNganh { get; set; }

        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
    }
}
