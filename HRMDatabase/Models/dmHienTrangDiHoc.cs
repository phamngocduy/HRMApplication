using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmHienTrangDiHoc
    {
        public dmHienTrangDiHoc()
        {
            this.nvQTHocTaps = new List<nvQTHocTap>();
            this.nvQTChungChis = new List<nvQTChungChi>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(20)]
        public string maHienTrangDiHoc { get; set; }
		[StringLength(50)]
        public string tenHienTrangDiHoc { get; set; }
        public Nullable<int> stt { get; set; }

        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
    }
}
