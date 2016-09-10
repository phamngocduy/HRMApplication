using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsQTKiemNhiem
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[Required]
        public int DonVi_id { get; set; }
        public string CongViec { get; set; }
		[StringLength(50)]
        public string PhuCap { get; set; }
		[StringLength(100)]
        public string GhiChu { get; set; }
		[StringLength(50)]
        public string HoVaTen { get; set; }
        public Nullable<int> sttDonVi { get; set; }
		[StringLength(10)]
        public string maDonVi { get; set; }
		[StringLength(100)]
        public string tenDonVi { get; set; }

    }
}
