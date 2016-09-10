using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class nvbhQuaTrinhBHXH
    {
		[Required]
        public int id { get; set; }
        public Nullable<int> idNVBHXH { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<long> MucLuongDongBHXH { get; set; }
        public Nullable<long> MucLuongDongBHTN { get; set; }
        public Nullable<long> MucDongBHXH { get; set; }
        public Nullable<long> MucDongBHTN { get; set; }
        public Nullable<double> HeSoTienLuongDongBHXH { get; set; }
        public Nullable<long> MucDongToiThieu { get; set; }
		[StringLength(200)]
        public string GhiChu1 { get; set; }
		[StringLength(200)]
        public string GhiChu2 { get; set; }
        public Nullable<int> NV_ID { get; set; }
        public Nullable<int> TG_ID { get; set; }
        public Nullable<long> TienLuong { get; set; }
        public Nullable<double> HSL { get; set; }
        public Nullable<int> SoNamNghiBHXH { get; set; }
        public Nullable<int> SoThangNghiBHXH { get; set; }
        public Nullable<long> TongMucDongBHXH { get; set; }
        public Nullable<long> TongMucDongBHTN { get; set; }
        public Nullable<long> TongMucDongBHYT { get; set; }
        public Nullable<bool> Hide { get; set; }

    }
}
