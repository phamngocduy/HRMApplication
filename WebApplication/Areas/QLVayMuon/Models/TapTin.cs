using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class TapTin
    {
        public TapTin()
        {
            this.TapTin1 = new List<TapTin>();
        }

        public int id { get; set; }
        public Nullable<int> idTapTin { get; set; }
        public string tenThuMuc { get; set; }
        public string tepDinhKem { get; set; }
        public bool laThuMuc { get; set; }
        public string tengiayto { get; set; }
        public virtual ICollection<TapTin> TapTin1 { get; set; }
        public virtual TapTin TapTin2 { get; set; }
    }
}
