using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmThanhPhanGiaDinh
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maThanhPhanGiaDinh { get; set; }
		[Required]
		[StringLength(50)]
        public string tenThanhPhanGiaDinh { get; set; }

    }
}
