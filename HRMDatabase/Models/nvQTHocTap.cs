using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvQTHocTap
    {
        public nvQTHocTap()
        {
            this.nvBangCaps = new List<nvBangCap>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<int> LoaiHocTap_id { get; set; }
        public string TenTruong { get; set; }
        public Nullable<int> LoaiBangCap_id { get; set; }
        public Nullable<int> ChuyenNganh_id { get; set; }
        public string ChuyenNganh { get; set; }
        public Nullable<int> NoiHoc_id { get; set; }
        public Nullable<int> QuocGia_id { get; set; }
        public Nullable<int> LoaiHinhDaoTao_id { get; set; }
        public Nullable<System.DateTime> BatDau { get; set; }
        public Nullable<System.DateTime> KetThucDuKien { get; set; }
        public Nullable<System.DateTime> KetThucChinhThuc { get; set; }
        public Nullable<int> XepLoaiTotNghiep_id { get; set; }
		[StringLength(50)]
        public string HocPhi { get; set; }
		[StringLength(50)]
        public string KinhPhiHoTro { get; set; }
		[StringLength(50)]
        public string KinhPhiKhac { get; set; }
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> NgayCapQuyetDinh { get; set; }
        public string CamKet { get; set; }
		[StringLength(50)]
        public string ThuongHoanThanh { get; set; }
		[Required]
        public bool DieuChinhLuong { get; set; }
        public Nullable<int> HienTrang_id { get; set; }
        public Nullable<int> CheDo_id { get; set; }
        public string GhiChu { get; set; }

		[ForeignKey("CheDo_id")]
        public virtual dmCheDoHoc dmCheDoHoc { get; set; }
		[ForeignKey("ChuyenNganh_id")]
        public virtual dmChuyenNganh dmChuyenNganh { get; set; }
		[ForeignKey("DonVi_id")]
        public virtual dmDonVi dmDonVi { get; set; }
		[ForeignKey("HienTrang_id")]
        public virtual dmHienTrangDiHoc dmHienTrangDiHoc { get; set; }
		[ForeignKey("LoaiBangCap_id")]
        public virtual dmLoaiBangCap dmLoaiBangCap { get; set; }
		[ForeignKey("LoaiHinhDaoTao_id")]
        public virtual dmLoaiHinhDaoTao dmLoaiHinhDaoTao { get; set; }
		[ForeignKey("LoaiHocTap_id")]
        public virtual dmLoaiHocTap dmLoaiHocTap { get; set; }
		[ForeignKey("NoiHoc_id")]
        public virtual dmNoiHoc dmNoiHoc { get; set; }
		[ForeignKey("QuocGia_id")]
        public virtual dmQuocGia dmQuocGia { get; set; }
		[ForeignKey("XepLoaiTotNghiep_id")]
        public virtual dmXepLoaiTotNghiep dmXepLoaiTotNghiep { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<nvBangCap> nvBangCaps { get; set; }
    }
}
