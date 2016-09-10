using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmXepLoaiTotNghiep
    {
        public dmXepLoaiTotNghiep()
        {
            this.nvBangCaps = new List<nvBangCap>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maXepLoaiTotNghiep { get; set; }
		[Required]
		[StringLength(150)]
        public string tenXepLoaiTotNghiep { get; set; }

        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
    }
}
