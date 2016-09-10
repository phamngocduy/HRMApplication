using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmHocVi
    {
        public dmHocVi()
        {
            this.dmDanhHieux = new List<dmDanhHieu>();
            this.nvTrangThaiLuongs = new List<nvTrangThaiLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maHocVi { get; set; }
		[Required]
		[StringLength(50)]
        public string tenHocVi { get; set; }
        public Nullable<int> idTrinhDo { get; set; }

        public virtual ICollection<dmDanhHieu> dmDanhHieux { get; set; }
		[ForeignKey("idTrinhDo")]
        public virtual dmTrinhDo dmTrinhDo { get; set; }
        public virtual ICollection<nvTrangThaiLuong> nvTrangThaiLuongs { get; set; }
    }
}
