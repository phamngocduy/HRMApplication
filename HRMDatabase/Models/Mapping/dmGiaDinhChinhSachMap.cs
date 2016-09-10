using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmGiaDinhChinhSachMap : EntityTypeConfiguration<dmGiaDinhChinhSach>
    {
        public dmGiaDinhChinhSachMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maGiaDinhChinhSach)
                .HasMaxLength(10);

            this.Property(t => t.tenGiaDinhChinhSach)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmGiaDinhChinhSach");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maGiaDinhChinhSach).HasColumnName("maGiaDinhChinhSach");
            this.Property(t => t.tenGiaDinhChinhSach).HasColumnName("tenGiaDinhChinhSach");
        }
    }
}
