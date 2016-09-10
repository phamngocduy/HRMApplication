using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmNoiKCB
    {
        public dmNoiKCB()
        {
            this.nvbhNhanVienBHXHs = new List<nvbhNhanVienBHXH>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string MaBV { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> Stt { get; set; }
		[StringLength(200)]
        public string TenBV { get; set; }

        public virtual ICollection<nvbhNhanVienBHXH> nvbhNhanVienBHXHs { get; set; }
    }
}
