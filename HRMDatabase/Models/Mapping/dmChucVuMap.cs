using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChucVuMap : EntityTypeConfiguration<dmChucVu>
    {
        public dmChucVuMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChucVu)
                .HasMaxLength(10);

            this.Property(t => t.tenChucVu)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dmChucVu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maChucVu).HasColumnName("maChucVu");
            this.Property(t => t.tenChucVu).HasColumnName("tenChucVu");
        }
    }
}
