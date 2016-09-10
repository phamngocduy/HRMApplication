using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQLHoSoHSLMap : EntityTypeConfiguration<nvQLHoSoHSL>
    {
        public nvQLHoSoHSLMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("nvQLHoSoHSL");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HSL_id).HasColumnName("HSL_id");
            this.Property(t => t.BanTuNhanXet).HasColumnName("BanTuNhanXet");
            this.Property(t => t.BienBanHopDonVi).HasColumnName("BienBanHopDonVi");
            this.Property(t => t.DeXuatTruongDonVi).HasColumnName("DeXuatTruongDonVi");
            this.Property(t => t.HoanThanh).HasColumnName("HoanThanh");
            this.Property(t => t.BacLuong).HasColumnName("BacLuong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.ThoiGianGiuBac).HasColumnName("ThoiGianGiuBac");

            // Relationships
            this.HasRequired(t => t.nvHeSoLuong)
                .WithMany(t => t.nvQLHoSoHSLs)
                .HasForeignKey(d => d.HSL_id)
				.WillCascadeOnDelete(false);

        }
    }
}
