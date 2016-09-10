using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvNganhGiangDay
    {
        public nvNganhGiangDay()
        {
            this.bcKhoaGiangDays = new List<bcKhoaGiangDay>();
            this.NhanViens = new List<NhanVien>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int NganhGiangDay { get; set; }
		[Required]
        public System.DateTime ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[Required]
        public int KhoaGiangDay { get; set; }

        public virtual ICollection<bcKhoaGiangDay> bcKhoaGiangDays { get; set; }
		[ForeignKey("KhoaGiangDay")]
        public virtual dmDonVi dmDonVi { get; set; }
		[ForeignKey("NganhGiangDay")]
        public virtual dmNganhGiangDay dmNganhGiangDay { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
