using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTChungChi
    {
        public nvQTChungChi()
        {
            this.ChungChis = new List<ChungChi>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> NV_id { get; set; }
		[Required]
        public int DonVi_id { get; set; }
        public Nullable<int> LoaiChungChi_id { get; set; }
        public string TenKhoaHoc { get; set; }
        public string TenTruong { get; set; }
        public Nullable<int> NoiHoc_id { get; set; }
        public Nullable<int> QuocGia_id { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThucDuKien { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThucChinhThuc { get; set; }
        public string KetQua { get; set; }
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> NgayCapQD { get; set; }
		[StringLength(50)]
        public string KinhPhiHoTro { get; set; }
		[StringLength(50)]
        public string HocPhi { get; set; }
		[StringLength(50)]
        public string ChiPhiKhac { get; set; }
        public Nullable<int> HienTrang_id { get; set; }
        public Nullable<int> CheDo_id { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }
        public Nullable<bool> Xoa { get; set; }

        public virtual ICollection<ChungChi> ChungChis { get; set; }
		[ForeignKey("CheDo_id")]
        public virtual dmCheDoHoc dmCheDoHoc { get; set; }
		[ForeignKey("DonVi_id")]
        public virtual dmDonVi dmDonVi { get; set; }
		[ForeignKey("HienTrang_id")]
        public virtual dmHienTrangDiHoc dmHienTrangDiHoc { get; set; }
		[ForeignKey("LoaiChungChi_id")]
        public virtual dmLoaiChungChi dmLoaiChungChi { get; set; }
		[ForeignKey("NoiHoc_id")]
        public virtual dmNoiHoc dmNoiHoc { get; set; }
		[ForeignKey("QuocGia_id")]
        public virtual dmQuocGia dmQuocGia { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
