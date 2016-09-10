using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmCongTacDoanThe
    {
        public dmCongTacDoanThe()
        {
            this.dmChucVuDoanThes = new List<dmChucVuDoanThe>();
            this.nvCTDoanTheTruocs = new List<nvCTDoanTheTruoc>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maCongTacDoanThe { get; set; }
		[Required]
		[StringLength(50)]
        public string tenCongTacDoanThe { get; set; }

        public virtual ICollection<dmChucVuDoanThe> dmChucVuDoanThes { get; set; }
        public virtual ICollection<nvCTDoanTheTruoc> nvCTDoanTheTruocs { get; set; }
    }
}
