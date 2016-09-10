using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmDanTocMap : EntityTypeConfiguration<dmDanToc>
    {
        public dmDanTocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenDanToc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmDanToc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.tenDanToc).HasColumnName("tenDanToc");
            this.Property(t => t.laThieuSo).HasColumnName("laThieuSo");
        }
    }
}
