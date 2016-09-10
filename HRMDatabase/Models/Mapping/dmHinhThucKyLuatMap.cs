using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHinhThucKyLuatMap : EntityTypeConfiguration<dmHinhThucKyLuat>
    {
        public dmHinhThucKyLuatMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHinhThucKyLuat)
                .HasMaxLength(10);

            this.Property(t => t.tenHinhThucKyLuat)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHinhThucKyLuat");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maHinhThucKyLuat).HasColumnName("maHinhThucKyLuat");
            this.Property(t => t.tenHinhThucKyLuat).HasColumnName("tenHinhThucKyLuat");
        }
    }
}
