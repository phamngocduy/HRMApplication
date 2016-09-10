using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class NhanVienVayMuon
    {
        public NhanVienVayMuon()
        {
            this.KhoanVays = new List<KhoanVay>();
        }

		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(10)]
        public string MaNV { get; set; }
		[StringLength(100)]
        public string HoVaTen { get; set; }
		[StringLength(100)]
        public string DonVi { get; set; }
        public Nullable<long> SoDuNoCuoiKy { get; set; }
        public Nullable<long> TongSoTienVay { get; set; }
        public Nullable<long> TongSoTienHoan { get; set; }
        public Nullable<long> TongSoTienLai { get; set; }
        public Nullable<int> SoThangConLaiPhaiTra { get; set; }
        public Nullable<bool> Hidden { get; set; }
		[Required]
        public int DonVi_id { get; set; }
        public Nullable<int> NV_id { get; set; }
		[Required]
        public bool TrangThai { get; set; }

        public virtual ICollection<KhoanVay> KhoanVays { get; set; }
    }
}
