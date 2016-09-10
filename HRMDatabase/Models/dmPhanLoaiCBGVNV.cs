using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmPhanLoaiCBGVNV
    {
        public dmPhanLoaiCBGVNV()
        {
            this.nvTTThongKes = new List<nvTTThongKe>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maPhanLoaiCBGVNV { get; set; }
		[Required]
		[StringLength(50)]
        public string tenPhanLoaiCBGVNV { get; set; }

        public virtual ICollection<nvTTThongKe> nvTTThongKes { get; set; }
    }
}
