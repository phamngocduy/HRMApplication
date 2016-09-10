using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class nvbhTongHopCuoiKy
    {
        public int id { get; set; }
        public Nullable<System.DateTime> KyBaoCao { get; set; }
        public Nullable<int> BHXH_SLD_Truoc { get; set; }
        public Nullable<int> BHXH_SLD_Nay { get; set; }
        public Nullable<int> BHYT_SLD_Truoc { get; set; }
        public Nullable<int> BHYT_SLD_Nay { get; set; }
        public Nullable<int> BHTN_SLD_Truoc { get; set; }
        public Nullable<int> BHTN_SLD_Nay { get; set; }
        public Nullable<long> BHXH_QL_Truoc { get; set; }
        public Nullable<long> BHXH_QL_Nay { get; set; }
        public Nullable<long> BHYT_QL_Truoc { get; set; }
        public Nullable<long> BHYT_QL_Nay { get; set; }
        public Nullable<long> BHTN_QL_Truoc { get; set; }
        public Nullable<long> BHTN_QL_Nay { get; set; }
        public Nullable<long> BHXH_SPD_Truoc { get; set; }
        public Nullable<long> BHXH_SPD_Nay { get; set; }
        public Nullable<long> BHYT_SPD_Truoc { get; set; }
        public Nullable<long> BHYT_SPD_Nay { get; set; }
        public Nullable<long> BHTN_SPD_Truoc { get; set; }
        public Nullable<long> BHTN_SPD_Nay { get; set; }
    }
}
