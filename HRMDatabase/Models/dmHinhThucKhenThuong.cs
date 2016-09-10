using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmHinhThucKhenThuong
    {
        public dmHinhThucKhenThuong()
        {
            this.nvTTKhenThuongs = new List<nvTTKhenThuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maHinhThucKhenThuong { get; set; }
		[Required]
		[StringLength(50)]
        public string tenHinhThucKhenThuong { get; set; }

        public virtual ICollection<nvTTKhenThuong> nvTTKhenThuongs { get; set; }
    }
}
