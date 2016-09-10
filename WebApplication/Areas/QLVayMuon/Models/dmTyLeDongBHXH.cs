using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmTyLeDongBHXH
    {
        public dmTyLeDongBHXH()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

        public int id { get; set; }
        public System.DateTime NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string DoanhNghiepBHXH { get; set; }
        public string NguoiLDBHXH { get; set; }
        public string TongBHXH { get; set; }
        public string DoanhNghiepBHYT { get; set; }
        public string NguoiLDBHYT { get; set; }
        public string TongBHYT { get; set; }
        public string DoanhNghiepBHTN { get; set; }
        public string NguoiLDBHTN { get; set; }
        public string TongBHTN { get; set; }
        public string TongCong { get; set; }
        public bool TrangThai { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> SoNgayConLai { get; set; }
        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
