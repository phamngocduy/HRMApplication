using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class ChiTietVayMuon
    {
        public int id { get; set; }
        public Nullable<int> idVm { get; set; }
        public Nullable<int> IdNhanVienVayMuon { get; set; }
        public System.DateTime NgayChungTu { get; set; }
        public string SoChungTu { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> MucDichSuDung { get; set; }
        public Nullable<bool> Dinhmuc { get; set; }
        public Nullable<long> SoTienVay { get; set; }
        public Nullable<long> SotienHoan { get; set; }
        public Nullable<long> SotienLai { get; set; }
        public Nullable<int> idvay { get; set; }
        public Nullable<int> idhoan { get; set; }
        public virtual dmMucDichSuDung dmMucDichSuDung { get; set; }
    }
}
