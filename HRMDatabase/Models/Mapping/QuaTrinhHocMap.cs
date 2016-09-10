using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class QuaTrinhHocMap : EntityTypeConfiguration<QuaTrinhHoc>
    {
        public QuaTrinhHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.BacHoc)
                .HasMaxLength(50);

            this.Property(t => t.TruongHoc)
                .HasMaxLength(150);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("QuaTrinhHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.BacHoc).HasColumnName("BacHoc");
            this.Property(t => t.TruongHoc).HasColumnName("TruongHoc");
            this.Property(t => t.NamBatDau).HasColumnName("NamBatDau");
            this.Property(t => t.NamKetThuc).HasColumnName("NamKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.QuaTrinhHocs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
