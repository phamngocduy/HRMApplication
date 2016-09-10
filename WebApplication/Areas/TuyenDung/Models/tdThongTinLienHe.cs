using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class tdThongTinLienHe
    {
        public tdThongTinLienHe()
        {
            this.tdDiaChiLienLacs = new List<tdDiaChiLienLac>();
            this.tdHoKhauThuongTrus = new List<tdHoKhauThuongTru>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int UngVien_id { get; set; }
		[StringLength(15)]
        public string DTDiDong1 { get; set; }
		[StringLength(15)]
        public string DTDiDong2 { get; set; }
		[StringLength(15)]
        public string DTNha { get; set; }
		[StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<tdDiaChiLienLac> tdDiaChiLienLacs { get; set; }
        public virtual ICollection<tdHoKhauThuongTru> tdHoKhauThuongTrus { get; set; }
		[ForeignKey("UngVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
