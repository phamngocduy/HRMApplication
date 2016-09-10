using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmQuocGia
    {
        public dmQuocGia()
        {
            this.BoiDuongChuyenMons = new List<BoiDuongChuyenMon>();
            this.nvBangCaps = new List<nvBangCap>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
            this.nvQTChungChis = new List<nvQTChungChi>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maQuocGia { get; set; }
		[Required]
		[StringLength(100)]
        public string tenQuocGia { get; set; }

        public virtual ICollection<BoiDuongChuyenMon> BoiDuongChuyenMons { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
    }
}
