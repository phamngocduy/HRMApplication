using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdLoaiTheDinhDanhMap : EntityTypeConfiguration<tdLoaiTheDinhDanh>
    {
        public tdLoaiTheDinhDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.LoaiTheDinhDanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tdLoaiTheDinhDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LoaiTheDinhDanh).HasColumnName("LoaiTheDinhDanh");
        }
    }
}
