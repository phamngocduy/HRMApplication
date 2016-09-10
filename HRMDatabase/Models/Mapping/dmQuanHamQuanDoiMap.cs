using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmQuanHamQuanDoiMap : EntityTypeConfiguration<dmQuanHamQuanDoi>
    {
        public dmQuanHamQuanDoiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maQuanHamQuanDoi)
                .HasMaxLength(10);

            this.Property(t => t.tenQuanHamQuanDoi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmQuanHamQuanDoi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maQuanHamQuanDoi).HasColumnName("maQuanHamQuanDoi");
            this.Property(t => t.tenQuanHamQuanDoi).HasColumnName("tenQuanHamQuanDoi");
        }
    }
}
