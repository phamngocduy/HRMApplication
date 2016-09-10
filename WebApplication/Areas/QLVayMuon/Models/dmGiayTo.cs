using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmGiayTo
    {
        public dmGiayTo()
        {
            this.HoSoVayMuons = new List<HoSoVayMuon>();
        }

        public int id { get; set; }
        public Nullable<int> idMucDichSuDung { get; set; }
        public string MaGiayTo { get; set; }
        public string TenGiayTo { get; set; }
        public Nullable<int> stt { get; set; }
        public virtual dmMucDichSuDung dmMucDichSuDung { get; set; }
        public virtual ICollection<HoSoVayMuon> HoSoVayMuons { get; set; }
    }
}
