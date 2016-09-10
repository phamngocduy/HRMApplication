using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Extension.Databases.Models.Mapping
{
    public class nvSoYeuLyLichMap : EntityTypeConfiguration<nvSoYeuLyLich>
    {
        public nvSoYeuLyLichMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.TenGoiKhac)
                .HasMaxLength(50);

            this.Property(t => t.NoiSinhKhac)
                .HasMaxLength(100);

            this.Property(t => t.QueQuanKhac)
                .HasMaxLength(100);

            this.Property(t => t.NgheNghiep)
                .HasMaxLength(50);

            this.Property(t => t.CoQuanTuyenDung)
                .HasMaxLength(50);

            this.Property(t => t.ChucVuHienTai)
                .HasMaxLength(50);

            this.Property(t => t.CongViecDuocGiao)
                .HasMaxLength(50);

            this.Property(t => t.MaNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.BacLuong_id)
                .HasMaxLength(50);

            this.Property(t => t.TrinhDoNgoaiNgu)
                .HasMaxLength(100);

            this.Property(t => t.TrinhDoTinHoc)
                .HasMaxLength(100);

            this.Property(t => t.SoTruongCongTac)
                .HasMaxLength(50);

            this.Property(t => t.TinhTrangSucKhoe)
                .HasMaxLength(50);

            this.Property(t => t.ssBaoHiemXaHoi)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("nvSoYeuLyLich");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.TenGoiKhac).HasColumnName("TenGoiKhac");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.GioiTinh_id).HasColumnName("GioiTinh_id");
            this.Property(t => t.NoiSinh_id).HasColumnName("NoiSinh_id");
            this.Property(t => t.QueQuan_id).HasColumnName("QueQuan_id");
            this.Property(t => t.NoiSinh_TinhThanh_id).HasColumnName("NoiSinh_TinhThanh_id");
            this.Property(t => t.NoiSinh_QuanHuyen_id).HasColumnName("NoiSinh_QuanHuyen_id");
            this.Property(t => t.NoiSinh_PhuongXa_id).HasColumnName("NoiSinh_PhuongXa_id");
            this.Property(t => t.NoiSinhKhac).HasColumnName("NoiSinhKhac");
            this.Property(t => t.QueQuan_TinhThanh_id).HasColumnName("QueQuan_TinhThanh_id");
            this.Property(t => t.QueQuan_PhuongXa_id).HasColumnName("QueQuan_PhuongXa_id");
            this.Property(t => t.QueQuan_QuanHuyen_id).HasColumnName("QueQuan_QuanHuyen_id");
            this.Property(t => t.QueQuanKhac).HasColumnName("QueQuanKhac");
            this.Property(t => t.DanToc_id).HasColumnName("DanToc_id");
            this.Property(t => t.TonGiao_id).HasColumnName("TonGiao_id");
            this.Property(t => t.QuocTich_id).HasColumnName("QuocTich_id");
            this.Property(t => t.ChungMinhNhanDan_id).HasColumnName("ChungMinhNhanDan_id");
            this.Property(t => t.HoKhauThuongTru_id).HasColumnName("HoKhauThuongTru_id");
            this.Property(t => t.NoiOHienNay_id).HasColumnName("NoiOHienNay_id");
            this.Property(t => t.NgheNghiep).HasColumnName("NgheNghiep");
            this.Property(t => t.NgayTuyenDung).HasColumnName("NgayTuyenDung");
            this.Property(t => t.CoQuanTuyenDung).HasColumnName("CoQuanTuyenDung");
            this.Property(t => t.ChucVuHienTai).HasColumnName("ChucVuHienTai");
            this.Property(t => t.CongViecDuocGiao).HasColumnName("CongViecDuocGiao");
            this.Property(t => t.NgachVienChuc_id).HasColumnName("NgachVienChuc_id");
            this.Property(t => t.MaNgachVienChuc).HasColumnName("MaNgachVienChuc");
            this.Property(t => t.BacLuong_id).HasColumnName("BacLuong_id");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.NgayHuongLuong).HasColumnName("NgayHuongLuong");
            this.Property(t => t.PhuCapChucVu).HasColumnName("PhuCapChucVu");
            this.Property(t => t.PhuCapKhac).HasColumnName("PhuCapKhac");
            this.Property(t => t.TrinhDoHocVan_id).HasColumnName("TrinhDoHocVan_id");
            this.Property(t => t.HocHam_id).HasColumnName("HocHam_id");
            this.Property(t => t.HocVi_id).HasColumnName("HocVi_id");
            this.Property(t => t.LyLuanChinhTri_id).HasColumnName("LyLuanChinhTri_id");
            this.Property(t => t.TrinhDoNgoaiNgu).HasColumnName("TrinhDoNgoaiNgu");
            this.Property(t => t.TrinhDoTinHoc).HasColumnName("TrinhDoTinHoc");
            this.Property(t => t.NgayVaoDang).HasColumnName("NgayVaoDang");
            this.Property(t => t.NgayVaoDangChinhThuc).HasColumnName("NgayVaoDangChinhThuc");
            this.Property(t => t.HoatDongDoanHoi).HasColumnName("HoatDongDoanHoi");
            this.Property(t => t.NgayNhapNgu).HasColumnName("NgayNhapNgu");
            this.Property(t => t.NgayXuatNgu).HasColumnName("NgayXuatNgu");
            this.Property(t => t.QuanHamCaoNhat_id).HasColumnName("QuanHamCaoNhat_id");
            this.Property(t => t.DanhHieuCaoNhat_id).HasColumnName("DanhHieuCaoNhat_id");
            this.Property(t => t.SoTruongCongTac).HasColumnName("SoTruongCongTac");
            this.Property(t => t.TinhTrangSucKhoe).HasColumnName("TinhTrangSucKhoe");
            this.Property(t => t.ChieuCao).HasColumnName("ChieuCao");
            this.Property(t => t.CanNang).HasColumnName("CanNang");
            this.Property(t => t.LaThuongBinhHang_id).HasColumnName("LaThuongBinhHang_id");
            this.Property(t => t.GiaDinhChinhSach_id).HasColumnName("GiaDinhChinhSach_id");
            this.Property(t => t.ssBaoHiemXaHoi).HasColumnName("ssBaoHiemXaHoi");
            this.Property(t => t.DaNghiHuu).HasColumnName("DaNghiHuu");

            // Relationships
            this.HasOptional(t => t.NoiSinh)
                .WithMany(t => t.nvSoYeuLyLiches)
                .HasForeignKey(d => d.NoiSinh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.QueQuan)
                .WithMany(t => t.nvSoYeuLyLiches1)
                .HasForeignKey(d => d.QueQuan_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvSoYeuLyLiches)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.NoiOHienNay)
                .WithMany(t => t.nvSoYeuLyLiches)
                .HasForeignKey(d => d.NoiOHienNay_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.HoKhauThuongTru)
                .WithMany(t => t.nvSoYeuLyLiches1)
                .HasForeignKey(d => d.HoKhauThuongTru_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.ChungMinhThu)
                .WithMany(t => t.nvSoYeuLyLiches)
                .HasForeignKey(d => d.ChungMinhNhanDan_id)
				.WillCascadeOnDelete(false);

        }
    }
}
