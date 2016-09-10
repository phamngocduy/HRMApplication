using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class BuoiTapHuanMap : EntityTypeConfiguration<BuoiTapHuan>
    {
        public BuoiTapHuanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ThoiGianBatDau)
                .HasMaxLength(50);

            this.Property(t => t.ThoiGianKetThuc)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("BuoiTapHuan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TapHuan_id).HasColumnName("TapHuan_id");
            this.Property(t => t.NgayTapHuan).HasColumnName("NgayTapHuan");
            this.Property(t => t.BuoiTapHuan1).HasColumnName("BuoiTapHuan");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.TapHuan)
                .WithMany(t => t.BuoiTapHuans)
                .HasForeignKey(d => d.TapHuan_id)
				.WillCascadeOnDelete(false);

        }
    }
}
