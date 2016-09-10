using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTinhThanhMap : EntityTypeConfiguration<dmTinhThanh>
    {
        public dmTinhThanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTinhThanh)
                .HasMaxLength(10);

            this.Property(t => t.tenTinhThanh)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTinhThanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTinhThanh).HasColumnName("maTinhThanh");
            this.Property(t => t.tenTinhThanh).HasColumnName("tenTinhThanh");
        }
    }
}
