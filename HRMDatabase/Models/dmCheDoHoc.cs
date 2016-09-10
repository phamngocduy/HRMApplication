using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmCheDoHoc
    {
        public dmCheDoHoc()
        {
            this.nvQTChungChis = new List<nvQTChungChi>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(50)]
        public string maCheDoHoc { get; set; }
		[StringLength(200)]
        public string tenCheDoHoc { get; set; }

        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
    }
}
