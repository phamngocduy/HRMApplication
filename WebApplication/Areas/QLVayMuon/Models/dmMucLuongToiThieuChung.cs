using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmMucLuongToiThieuChung
    {
        public dmMucLuongToiThieuChung()
        {
            this.nvbhLaiTruyThuBHs = new List<nvbhLaiTruyThuBH>();
        }

        public int id { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public long MucLuong { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> SoNgayConLai { get; set; }
        public virtual ICollection<nvbhLaiTruyThuBH> nvbhLaiTruyThuBHs { get; set; }
    }
}
