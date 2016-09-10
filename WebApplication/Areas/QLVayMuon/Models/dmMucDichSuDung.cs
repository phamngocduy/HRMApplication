using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmMucDichSuDung
    {
        public dmMucDichSuDung()
        {
            this.ChiTietVayMuons = new List<ChiTietVayMuon>();
            this.dmGiayToes = new List<dmGiayTo>();
            this.KhoanVays = new List<KhoanVay>();
        }

        public int id { get; set; }
        public string MaMucDich { get; set; }
        public string TenMucDich { get; set; }
        public int HanMucToiDa { get; set; }
        public int ThoiGianHoanTien { get; set; }
        public string DonViThoiGian { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> stt { get; set; }
        public virtual ICollection<ChiTietVayMuon> ChiTietVayMuons { get; set; }
        public virtual ICollection<dmGiayTo> dmGiayToes { get; set; }
        public virtual ICollection<KhoanVay> KhoanVays { get; set; }
    }
}
