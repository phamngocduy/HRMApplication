using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class v_qtbhxh
    {
        public int id { get; set; }
        public Nullable<int> idNVBHXH { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<long> MucLuongDongBHXH { get; set; }
        public Nullable<long> MucDongBHXH { get; set; }
        public Nullable<long> MucDongBHTN { get; set; }
        public Nullable<double> HeSoTienLuongDongBHXH { get; set; }
        public Nullable<long> MucDongToiThieu { get; set; }
        public string GhiChu1 { get; set; }
        public string GhiChu2 { get; set; }
        public Nullable<int> NV_ID { get; set; }
        public Nullable<int> TG_ID { get; set; }
        public Nullable<long> TienLuong { get; set; }
        public Nullable<double> HSL { get; set; }
        public string HoVaTen { get; set; }
        public string MANV { get; set; }
        public string DonVi { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<int> SoKCB { get; set; }
        public Nullable<double> TLBHYT { get; set; }
        public Nullable<double> TLBHTN { get; set; }
        public Nullable<double> TLBHXH { get; set; }
        public Nullable<long> MLTTC { get; set; }
        public Nullable<long> MLTTV { get; set; }
    }
}
