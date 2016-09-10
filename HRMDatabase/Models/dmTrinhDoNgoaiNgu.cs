using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmTrinhDoNgoaiNgu
    {
        public dmTrinhDoNgoaiNgu()
        {
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maTrinhDoNgoaiNgu { get; set; }
		[Required]
		[StringLength(50)]
        public string tenTrinhDoNgoaiNgu { get; set; }

        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
    }
}
