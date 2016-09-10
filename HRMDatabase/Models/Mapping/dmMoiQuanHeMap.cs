using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmMoiQuanHeMap : EntityTypeConfiguration<dmMoiQuanHe>
    {
        public dmMoiQuanHeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maMoiQuanHe)
                .HasMaxLength(10);

            this.Property(t => t.tenMoiQuanHe)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("dmMoiQuanHe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maMoiQuanHe).HasColumnName("maMoiQuanHe");
            this.Property(t => t.tenMoiQuanHe).HasColumnName("tenMoiQuanHe");
        }
    }
}
