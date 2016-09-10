using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmNhomNganh
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maNhomNganh { get; set; }
		[Required]
		[StringLength(150)]
        public string tenNhomNganh { get; set; }

    }
}
