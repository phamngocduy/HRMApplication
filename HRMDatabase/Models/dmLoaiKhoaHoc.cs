using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiKhoaHoc
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiKhoaHoc { get; set; }
		[Required]
		[StringLength(150)]
        public string tenLoaiKhoaHoc { get; set; }

    }
}
