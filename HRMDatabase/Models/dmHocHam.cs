using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmHocHam
    {
        public dmHocHam()
        {
            this.nvHocHams = new List<nvHocHam>();
            this.nvTrangThaiLuongs = new List<nvTrangThaiLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maHocHam { get; set; }
		[Required]
		[StringLength(50)]
        public string tenHocHam { get; set; }
		[Required]
        public byte doUuTien { get; set; }

        public virtual ICollection<nvHocHam> nvHocHams { get; set; }
        public virtual ICollection<nvTrangThaiLuong> nvTrangThaiLuongs { get; set; }
    }
}
