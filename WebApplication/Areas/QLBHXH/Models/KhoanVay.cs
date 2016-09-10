using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class KhoanVay
    {
        public KhoanVay()
        {
            this.HoanVays = new List<HoanVay>();
            this.HoSoVayMuons = new List<HoSoVayMuon>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int idNhanVienVayMuon { get; set; }
		[Required]
        public int idMucDichSuDung { get; set; }
		[Required]
		[StringLength(10)]
        public string SoChungTu { get; set; }
		[Required]
        public System.DateTime NgayChungTu { get; set; }
		[Required]
		[StringLength(200)]
        public string DienGiai { get; set; }
		[Required]
        public bool DinhMuc { get; set; }
		[Required]
        public long SoTienVay { get; set; }
		[Required]
        public int SoThang { get; set; }
        public Nullable<int> SoNgay { get; set; }
        public Nullable<System.DateTime> TraTuThang { get; set; }
        public Nullable<System.DateTime> TraDenThang { get; set; }
		[Required]
        public bool DatraXong { get; set; }
        public Nullable<int> SttMucDich { get; set; }

		[ForeignKey("idMucDichSuDung")]
        public virtual dmMucDichSuDung dmMucDichSuDung { get; set; }
        public virtual ICollection<HoanVay> HoanVays { get; set; }
        public virtual ICollection<HoSoVayMuon> HoSoVayMuons { get; set; }
		[ForeignKey("idNhanVienVayMuon")]
        public virtual NhanVienVayMuon NhanVienVayMuon { get; set; }
    }
}
