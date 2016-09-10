using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmNoiHoc
    {
        public dmNoiHoc()
        {
            this.BoiDuongChuyenMons = new List<BoiDuongChuyenMon>();
            this.nvBangCaps = new List<nvBangCap>();
            this.nvQTHocTaps = new List<nvQTHocTap>();
            this.nvQTChungChis = new List<nvQTChungChi>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(20)]
        public string maNoiHoc { get; set; }
		[StringLength(100)]
        public string tenNoiHoc { get; set; }

        public virtual ICollection<BoiDuongChuyenMon> BoiDuongChuyenMons { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
        public virtual ICollection<nvQTHocTap> nvQTHocTaps { get; set; }
        public virtual ICollection<nvQTChungChi> nvQTChungChis { get; set; }
    }
}
