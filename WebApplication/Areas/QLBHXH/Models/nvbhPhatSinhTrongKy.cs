using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhPhatSinhTrongKy
    {
		[Required]
        public int id { get; set; }
        public Nullable<System.DateTime> KyBaoCao { get; set; }
        public Nullable<int> BHXH_SLD_Tang { get; set; }
        public Nullable<int> BHXH_SLD_Giam { get; set; }
        public Nullable<int> BHYT_SLD_Tang { get; set; }
        public Nullable<int> BHYT_SLD_Giam { get; set; }
        public Nullable<int> BHTN_SLD_Tang { get; set; }
        public Nullable<int> BHTN_SLD_Giam { get; set; }
        public Nullable<long> BHXH_QL_Tang { get; set; }
        public Nullable<long> BHXH_QL_Giam { get; set; }
        public Nullable<long> BHYT_QL_Tang { get; set; }
        public Nullable<long> BHYT_QL_Giam { get; set; }
        public Nullable<long> BHTN_QL_Tang { get; set; }
        public Nullable<long> BHTN_QL_Giam { get; set; }
        public Nullable<long> BHXH_SPD_Tang { get; set; }
        public Nullable<long> BHXH_SPD_Giam { get; set; }
        public Nullable<long> BHYT_SPD_Tang { get; set; }
        public Nullable<long> BHYT_SPD_Giam { get; set; }
        public Nullable<long> BHTN_SPD_Tang { get; set; }
        public Nullable<long> BHTN_SPD_Giam { get; set; }
        public Nullable<long> BHXH_DC_Tang { get; set; }
        public Nullable<long> BHXH_DC_Giam { get; set; }
        public Nullable<long> BHYT_DC_Tang { get; set; }
        public Nullable<long> BHYT_DC_Giam { get; set; }
        public Nullable<long> BHTN_DC_Tang { get; set; }
        public Nullable<long> BHTN_DC_Giam { get; set; }

    }
}
