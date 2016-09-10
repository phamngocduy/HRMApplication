using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiChungChi
    {
        public dmLoaiChungChi()
        {
            this.ChungChis = new List<ChungChi>();
            this.nvQTChungChis = new List<nvQTChungChi>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiChungChi { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiChungChi { get; set; }

        public virtual ICollection<ChungChi> ChungChis { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
    }
}
