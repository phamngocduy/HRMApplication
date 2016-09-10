using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiCongTac
    {
        public dmLoaiCongTac()
        {
            this.CTNganHans = new List<CTNganHan>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiCongTac { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiCongTac { get; set; }

        public virtual ICollection<CTNganHan> CTNganHans { get; set; }
    }
}
