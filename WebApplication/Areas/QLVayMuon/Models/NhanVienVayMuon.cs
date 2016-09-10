using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class NhanVienVayMuon
    {
        public NhanVienVayMuon()
        {
            this.KhoanVays = new List<KhoanVay>();
        }

        public int id { get; set; }
        public string MaNV { get; set; }
        public string HoVaTen { get; set; }
        public string DonVi { get; set; }
        public Nullable<long> SoDuNoCuoiKy { get; set; }
        public Nullable<long> TongSoTienVay { get; set; }
        public Nullable<long> TongSoTienHoan { get; set; }
        public Nullable<long> TongSoTienLai { get; set; }
        public Nullable<int> SoThangConLaiPhaiTra { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public int DonVi_id { get; set; }
        public Nullable<int> NV_id { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<KhoanVay> KhoanVays { get; set; }
    }
}
