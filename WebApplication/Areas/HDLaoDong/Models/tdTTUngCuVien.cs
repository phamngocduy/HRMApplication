using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class tdTTUngCuVien
    {
        public tdTTUngCuVien()
        {
            this.tdBangCaps = new List<tdBangCap>();
            this.tdKetQuaTuyenDungs = new List<tdKetQuaTuyenDung>();
            this.tdKiemTraHS = new List<tdKiemTraH>();
            this.tdNoiSinhs = new List<tdNoiSinh>();
            this.tdQuaTrinhTuyenDungs = new List<tdQuaTrinhTuyenDung>();
            this.tdTheDinhDanhs = new List<tdTheDinhDanh>();
            this.tdThongTinLienHes = new List<tdThongTinLienHe>();
            this.tdThongTinUngTuyens = new List<tdThongTinUngTuyen>();
            this.tdXemVaXepLichHens = new List<tdXemVaXepLichHen>();
        }

		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(100)]
        public string HoVaTen { get; set; }
		[Required]
        public int GioiTinh_id { get; set; }
		[Required]
        public System.DateTime NgaySinh { get; set; }
		[StringLength(50)]
        public string TTHonNhan { get; set; }
        public Nullable<int> TPGiaDinh_id { get; set; }
        public Nullable<int> DanToc_id { get; set; }
        public Nullable<int> TonGiao_id { get; set; }
        public Nullable<int> QuocTich_id { get; set; }
		[Required]
        public bool hidden { get; set; }
        public Nullable<bool> KetQuaTuyenDung { get; set; }

        public virtual ICollection<tdBangCap> tdBangCaps { get; set; }
        public virtual ICollection<tdKetQuaTuyenDung> tdKetQuaTuyenDungs { get; set; }
        public virtual ICollection<tdKiemTraH> tdKiemTraHS { get; set; }
        public virtual ICollection<tdNoiSinh> tdNoiSinhs { get; set; }
        public virtual ICollection<tdQuaTrinhTuyenDung> tdQuaTrinhTuyenDungs { get; set; }
        public virtual ICollection<tdTheDinhDanh> tdTheDinhDanhs { get; set; }
        public virtual ICollection<tdThongTinLienHe> tdThongTinLienHes { get; set; }
        public virtual ICollection<tdThongTinUngTuyen> tdThongTinUngTuyens { get; set; }
        public virtual ICollection<tdXemVaXepLichHen> tdXemVaXepLichHens { get; set; }
    }
}
