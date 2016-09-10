using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class nvbhDanhSachDieuChinhChucDanh
    {
        public int id { get; set; }
        public Nullable<int> idLoaiDieuChinh { get; set; }
        public Nullable<int> idnvbhNhanVienBHXH { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
        public string ChucVuCu { get; set; }
        public string ChucVuMoi { get; set; }
        public Nullable<System.DateTime> TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public string GhiChu { get; set; }
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
        public virtual nvbhNhanVienBHXH nvbhNhanVienBHXH { get; set; }
    }
}
