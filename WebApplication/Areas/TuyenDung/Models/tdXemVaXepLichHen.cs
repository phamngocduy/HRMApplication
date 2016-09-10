using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_TuyenDung.Models
{
    public partial class tdXemVaXepLichHen
    {
        public tdXemVaXepLichHen()
        {
            this.tdQuaTrinhTuyenDungs = new List<tdQuaTrinhTuyenDung>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int UngCuVien_id { get; set; }
        public Nullable<System.DateTime> NgayPhongVan { get; set; }
		[StringLength(50)]
        public string Gio { get; set; }
		[StringLength(150)]
        public string DiaDiemPhongVan { get; set; }
        public Nullable<int> DonViPhongVan_id { get; set; }
		[Required]
        public bool DaBaoChoUngCuVien { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<tdQuaTrinhTuyenDung> tdQuaTrinhTuyenDungs { get; set; }
		[ForeignKey("UngCuVien_id")]
        public virtual tdTTUngCuVien tdTTUngCuVien { get; set; }
    }
}
