using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Extension.Databases.Models.Mapping
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

            this.Property(t => t.GhiChu)
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
            this.Property(t => t.Chuyennganhchinh).HasColumnName("Chuyennganhchinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.DanhHieuChinh).HasColumnName("DanhHieuChinh");
            this.Property(t => t.Xoa).HasColumnName("Xoa");
            this.Property(t => t.SauKhiVeTruong).HasColumnName("SauKhiVeTruong");
            this.Property(t => t.HoTro).HasColumnName("HoTro");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvBangCaps)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
