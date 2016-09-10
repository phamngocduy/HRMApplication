using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmGiayTo
    {
        public dmGiayTo()
        {
            this.HoSoVayMuons = new List<HoSoVayMuon>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> idMucDichSuDung { get; set; }
		[StringLength(10)]
        public string MaGiayTo { get; set; }
		[Required]
		[StringLength(200)]
        public string TenGiayTo { get; set; }
        public Nullable<int> stt { get; set; }

		[ForeignKey("idMucDichSuDung")]
        public virtual dmMucDichSuDung MucDichSuDung { get; set; }
        public virtual ICollection<HoSoVayMuon> HoSoVayMuons { get; set; }
    }
}
