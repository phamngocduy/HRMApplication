using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class dmMauHopDong
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[Required]
		[StringLength(50)]
        public string tenMauHD { get; set; }
		[Required]
        public string hdNoiDung { get; set; }

    }
}
