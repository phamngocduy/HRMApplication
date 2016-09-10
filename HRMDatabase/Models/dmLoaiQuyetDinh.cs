using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiQuyetDinh
    {
        public dmLoaiQuyetDinh()
        {
            this.dmQuyetDinhs = new List<dmQuyetDinh>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string maLoaiQuyetDinh { get; set; }
		[Required]
		[StringLength(100)]
        public string tenLoaiQuyetDinh { get; set; }
        public Nullable<int> stt { get; set; }

        public virtual ICollection<dmQuyetDinh> dmQuyetDinhs { get; set; }
    }
}
