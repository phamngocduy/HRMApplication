using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmQuocGiaMap : EntityTypeConfiguration<dmQuocGia>
    {
        public dmQuocGiaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maQuocGia)
                .HasMaxLength(10);

            this.Property(t => t.tenQuocGia)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dmQuocGia");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maQuocGia).HasColumnName("maQuocGia");
            this.Property(t => t.tenQuocGia).HasColumnName("tenQuocGia");
        }
    }
}
