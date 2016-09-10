using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmChucVuDoanThe
    {
        public dmChucVuDoanThe()
        {
            this.nvCTDoanThes = new List<nvCTDoanThe>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[Required]
        public int idCongTacDoanThe { get; set; }
		[StringLength(10)]
        public string maChucVuDoanThe { get; set; }
		[Required]
		[StringLength(50)]
        public string tenChucVuDoanThe { get; set; }

		[ForeignKey("idCongTacDoanThe")]
        public virtual dmCongTacDoanThe dmCongTacDoanThe { get; set; }
        public virtual ICollection<nvCTDoanThe> nvCTDoanThes { get; set; }
    }
}
