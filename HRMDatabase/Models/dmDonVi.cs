using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmDonVi
    {
        public dmDonVi()
        {
            this.BoiDuongChuyenMons = new List<BoiDuongChuyenMon>();
            this.dmDonVi1 = new List<dmDonVi>();
            this.nvNganhGiangDays = new List<nvNganhGiangDay>();
            this.nvQLThuViecs = new List<nvQLThuViec>();
            this.nvQTChungChis = new List<nvQTChungChi>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
            this.nvQTKiemNhiems = new List<nvQTKiemNhiem>();
            this.nvQTLamViecs = new List<nvQTLamViec>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string maDonVi { get; set; }
		[Required]
		[StringLength(100)]
        public string tenDonVi { get; set; }
        public Nullable<int> idDonViChuQuan { get; set; }
		[StringLength(2)]
        public string Khoa_BoMon { get; set; }
        public Nullable<int> stt { get; set; }

        public virtual ICollection<BoiDuongChuyenMon> BoiDuongChuyenMons { get; set; }
        public virtual ICollection<dmDonVi> dmDonVi1 { get; set; }
		[ForeignKey("idDonViChuQuan")]
        public virtual dmDonVi DonViChuQuan { get; set; }
        public virtual ICollection<nvNganhGiangDay> nvNganhGiangDays { get; set; }
        public virtual ICollection<nvQLThuViec> nvQLThuViecs { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
        public virtual ICollection<nvQTKiemNhiem> nvQTKiemNhiems { get; set; }
        public virtual ICollection<nvQTLamViec> nvQTLamViecs { get; set; }
    }
}
