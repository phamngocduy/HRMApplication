using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChucDanhMap : EntityTypeConfiguration<dmChucDanh>
    {
        public dmChucDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChucDanh)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanh)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmChucDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maChucDanh).HasColumnName("maChucDanh");
            this.Property(t => t.tenChucDanh).HasColumnName("tenChucDanh");
        }
    }
}
