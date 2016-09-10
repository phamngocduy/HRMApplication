using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvBangCapMap : EntityTypeConfiguration<nvBangCap>
    {
        public nvBangCapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.TenTruong)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvBangCap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.LoaiBangCap_id).HasColumnName("LoaiBangCap_id");
            this.Property(t => t.DanhHieu_id).HasColumnName("DanhHieu_id");
            this.Property(t => t.TenTruong).HasColumnName("TenTruong");
            this.Property(t => t.ChuyenNganh_id).HasColumnName("ChuyenNganh_id");
            this.Property(t => t.ChuyenNganh).HasColumnName("ChuyenNganh");
            this.Property(t => t.LoaiHinhDaoTao_id).HasColumnName("LoaiHinhDaoTao_id");
            this.Property(t => t.NgayTN).HasColumnName("NgayTN");
            this.Property(t => t.XepLoaiTotNghiep_id).HasColumnName("XepLoaiTotNghiep_id");
            this.Property(t => t.ChuyenNganhChinh).HasColumnName("ChuyenNganhChinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.DanhHieuChinh).HasColumnName("DanhHieuChinh");
            this.Property(t => t.Xoa).HasColumnName("Xoa");
            this.Property(t => t.SauKhiVeTruong).HasColumnName("SauKhiVeTruong");
            this.Property(t => t.HoTro).HasColumnName("HoTro");

            // Relationships
            this.HasRequired(t => t.dmChuyenNganh)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.ChuyenNganh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmDanhHieu)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.DanhHieu_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmLoaiBangCap)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.LoaiBangCap_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmLoaiHinhDaoTao)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.LoaiHinhDaoTao_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmNoiHoc)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.NoiHoc_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmQuocGia)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.QuocGia_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmXepLoaiTotNghiep)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.XepLoaiTotNghiep_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvKinhPhiBangCap)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.HoTro)
				.WillCascadeOnDelete(false);

        }
    }
}
