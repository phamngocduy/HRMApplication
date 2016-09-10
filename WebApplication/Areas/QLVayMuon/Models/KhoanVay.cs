using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class KhoanVay
    {
        public KhoanVay()
        {
            this.HoanVays = new List<HoanVay>();
            this.HoSoVayMuons = new List<HoSoVayMuon>();
        }

        public int id { get; set; }
        public int idNhanVienVayMuon { get; set; }
        public int idMucDichSuDung { get; set; }
        public string SoChungTu { get; set; }
        public System.DateTime NgayChungTu { get; set; }
        public string DienGiai { get; set; }
        public bool DinhMuc { get; set; }
        public long SoTienVay { get; set; }
        public int SoThang { get; set; }
        public Nullable<int> SoNgay { get; set; }
        public Nullable<System.DateTime> TraTuThang { get; set; }
        public Nullable<System.DateTime> TraDenThang { get; set; }
        public bool DatraXong { get; set; }
        public Nullable<int> SttMucDich { get; set; }
        public virtual dmMucDichSuDung dmMucDichSuDung { get; set; }
        public virtual ICollection<HoanVay> HoanVays { get; set; }
        public virtual ICollection<HoSoVayMuon> HoSoVayMuons { get; set; }
        public virtual NhanVienVayMuon NhanVienVayMuon { get; set; }
    }
}
