using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmLaiSuatTruyThu
    {
        public dmLaiSuatTruyThu()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<System.DateTime> NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<double> BHXH { get; set; }
        public Nullable<double> BHYT { get; set; }
        public Nullable<double> BHTN { get; set; }
        public Nullable<int> STT { get; set; }

        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
