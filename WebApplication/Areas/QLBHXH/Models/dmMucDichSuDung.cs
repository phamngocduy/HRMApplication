using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmMucDichSuDung
    {
        public dmMucDichSuDung()
        {
            this.ChiTietVayMuons = new List<ChiTietVayMuon>();
            this.dmGiayToes = new List<dmGiayTo>();
            this.KhoanVays = new List<KhoanVay>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(10)]
        public string MaMucDich { get; set; }
		[Required]
		[StringLength(200)]
        public string TenMucDich { get; set; }
		[Required]
        public int HanMucToiDa { get; set; }
		[Required]
        public int ThoiGianHoanTien { get; set; }
		[StringLength(50)]
        public string DonViThoiGian { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> stt { get; set; }

        public virtual ICollection<ChiTietVayMuon> ChiTietVayMuons { get; set; }
        public virtual ICollection<dmGiayTo> dmGiayToes { get; set; }
        public virtual ICollection<KhoanVay> KhoanVays { get; set; }
    }
}
