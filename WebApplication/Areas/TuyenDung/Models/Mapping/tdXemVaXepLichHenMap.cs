using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdXemVaXepLichHenMap : EntityTypeConfiguration<tdXemVaXepLichHen>
    {
        public tdXemVaXepLichHenMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Gio)
                .HasMaxLength(50);

            this.Property(t => t.DiaDiemPhongVan)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("tdXemVaXepLichHen");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngCuVien_id).HasColumnName("UngCuVien_id");
            this.Property(t => t.NgayPhongVan).HasColumnName("NgayPhongVan");
            this.Property(t => t.Gio).HasColumnName("Gio");
            this.Property(t => t.DiaDiemPhongVan).HasColumnName("DiaDiemPhongVan");
            this.Property(t => t.DonViPhongVan_id).HasColumnName("DonViPhongVan_id");
            this.Property(t => t.DaBaoChoUngCuVien).HasColumnName("DaBaoChoUngCuVien");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdXemVaXepLichHens)
                .HasForeignKey(d => d.UngCuVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
