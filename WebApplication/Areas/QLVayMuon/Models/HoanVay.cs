using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class HoanVay
    {
        public int id { get; set; }
        public Nullable<int> idKhoanVay { get; set; }
        public string SoChungTu { get; set; }
        public System.DateTime NgayChungTu { get; set; }
        public string DienGiai { get; set; }
        public long SoTienHoan { get; set; }
        public long SoTienLai { get; set; }
        public string MaNV { get; set; }
        public bool TrangThai { get; set; }
        public Nullable<int> IdNV { get; set; }
        public virtual KhoanVay KhoanVay { get; set; }
    }
}
