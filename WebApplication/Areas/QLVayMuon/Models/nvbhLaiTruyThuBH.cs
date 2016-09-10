using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class nvbhLaiTruyThuBH
    {
        public int id { get; set; }
        public int iddmLaiSuatTruyThu { get; set; }
        public int iddmMucLuongToiThieuChung { get; set; }
        public int idnvbhNhanVienBHXH { get; set; }
        public int iddmTyLeDongBHXH { get; set; }
        public double TienLuongHoacChenhLechTienLuong { get; set; }
        public System.DateTime TuThangNam { get; set; }
        public System.DateTime DenThangNam { get; set; }
        public Nullable<int> SoThangTruyThu { get; set; }
        public Nullable<int> TongThoiGianChamDong { get; set; }
        public Nullable<double> TienLaiTruyThuBHXH { get; set; }
        public Nullable<double> TienLaiTruyThuBHTN { get; set; }
        public Nullable<double> TienLaiTruyThuBHYT { get; set; }
        public Nullable<double> TongCong { get; set; }
        public string GhiChu { get; set; }
        public virtual dmLaiSuatTruyThu dmLaiSuatTruyThu { get; set; }
        public virtual dmMucLuongToiThieuChung dmMucLuongToiThieuChung { get; set; }
        public virtual dmTyLeDongBHXH dmTyLeDongBHXH { get; set; }
        public virtual nvbhNhanVienBHXH nvbhNhanVienBHXH { get; set; }
    }
}
