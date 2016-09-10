using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTHocTapMap : EntityTypeConfiguration<nvQTHocTap>
    {
        public nvQTHocTapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HocPhi)
                .HasMaxLength(50);

            this.Property(t => t.KinhPhiHoTro)
                .HasMaxLength(50);

            this.Property(t => t.KinhPhiKhac)
                .HasMaxLength(50);

            this.Property(t => t.ThuongHoanThanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvQTHocTap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.LoaiHocTap_id).HasColumnName("LoaiHocTap_id");
            this.Property(t => t.TenTruong).HasColumnName("TenTruong");
            this.Property(t => t.LoaiBangCap_id).HasColumnName("LoaiBangCap_id");
            this.Property(t => t.ChuyenNganh_id).HasColumnName("ChuyenNganh_id");
            this.Property(t => t.ChuyenNganh).HasColumnName("ChuyenNganh");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.LoaiHinhDaoTao_id).HasColumnName("LoaiHinhDaoTao_id");
            this.Property(t => t.BatDau).HasColumnName("BatDau");
            this.Property(t => t.KetThucDuKien).HasColumnName("KetThucDuKien");
            this.Property(t => t.KetThucChinhThuc).HasColumnName("KetThucChinhThuc");
            this.Property(t => t.XepLoaiTotNghiep_id).HasColumnName("XepLoaiTotNghiep_id");
            this.Property(t => t.HocPhi).HasColumnName("HocPhi");
            this.Property(t => t.KinhPhiHoTro).HasColumnName("KinhPhiHoTro");
            this.Property(t => t.KinhPhiKhac).HasColumnName("KinhPhiKhac");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.NgayCapQuyetDinh).HasColumnName("NgayCapQuyetDinh");
            this.Property(t => t.CamKet).HasColumnName("CamKet");
            this.Property(t => t.ThuongHoanThanh).HasColumnName("ThuongHoanThanh");
            this.Property(t => t.DieuChinhLuong).HasColumnName("DieuChinhLuong");
            this.Property(t => t.HienTrang_id).HasColumnName("HienTrang_id");
            this.Property(t => t.CheDo_id).HasColumnName("CheDo_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasOptional(t => t.dmCheDoHoc)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.CheDo_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmChuyenNganh)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.ChuyenNganh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmDonVi)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmHienTrangDiHoc)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.HienTrang_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmLoaiBangCap)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.LoaiBangCap_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmLoaiHinhDaoTao)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.LoaiHinhDaoTao_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmLoaiHocTap)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.LoaiHocTap_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmNoiHoc)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.NoiHoc_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmQuocGia)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.QuocGia_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmXepLoaiTotNghiep)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.XepLoaiTotNghiep_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvQTHocTaps)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
