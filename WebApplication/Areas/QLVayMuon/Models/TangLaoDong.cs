using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class TangLaoDong
    {
        public Nullable<System.DateTime> Ngaybd { get; set; }
        public Nullable<System.DateTime> Ngaykt { get; set; }
        public Nullable<long> MLTTC { get; set; }
        public Nullable<long> MLTTV { get; set; }
        public Nullable<double> TLBHXH { get; set; }
        public Nullable<double> TLBHYT { get; set; }
        public Nullable<double> TLBHTN { get; set; }
        public int id { get; set; }
    }
}
