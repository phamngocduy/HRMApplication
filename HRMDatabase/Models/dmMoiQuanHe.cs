using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmMoiQuanHe
    {
        public dmMoiQuanHe()
        {
            this.nvQHGiaDinhs = new List<nvQHGiaDinh>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maMoiQuanHe { get; set; }
		[Required]
		[StringLength(20)]
        public string tenMoiQuanHe { get; set; }

        public virtual ICollection<nvQHGiaDinh> nvQHGiaDinhs { get; set; }
    }
}
