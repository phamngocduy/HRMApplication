using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmGioiTinhMap : EntityTypeConfiguration<dmGioiTinh>
    {
        public dmGioiTinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maGioiTinh)
                .HasMaxLength(10);

            this.Property(t => t.tenGioiTinh)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("dmGioiTinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maGioiTinh).HasColumnName("maGioiTinh");
            this.Property(t => t.tenGioiTinh).HasColumnName("tenGioiTinh");
        }
    }
}
