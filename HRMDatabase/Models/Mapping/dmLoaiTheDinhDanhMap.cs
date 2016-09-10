using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiTheDinhDanhMap : EntityTypeConfiguration<dmLoaiTheDinhDanh>
    {
        public dmLoaiTheDinhDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiTheDinhDanh)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiTheDinhDanh)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiTheDinhDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiTheDinhDanh).HasColumnName("maLoaiTheDinhDanh");
            this.Property(t => t.tenLoaiTheDinhDanh).HasColumnName("tenLoaiTheDinhDanh");
        }
    }
}
