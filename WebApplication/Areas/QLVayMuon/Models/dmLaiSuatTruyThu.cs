using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmLaiSuatTruyThu
    {
        public dmLaiSuatTruyThu()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

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
