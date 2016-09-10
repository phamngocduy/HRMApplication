using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsGiuBacLuong
    {
		[Required]
        public int HSL_id { get; set; }
        public Nullable<int> SoThangThayDoi { get; set; }

    }
}
