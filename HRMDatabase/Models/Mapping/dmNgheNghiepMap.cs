using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNgheNghiepMap : EntityTypeConfiguration<dmNgheNghiep>
    {
        public dmNgheNghiepMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maNgheNghiep)
                .HasMaxLength(10);

            this.Property(t => t.tenNgheNghiep)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmNgheNghiep");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maNgheNghiep).HasColumnName("maNgheNghiep");
            this.Property(t => t.tenNgheNghiep).HasColumnName("tenNgheNghiep");
        }
    }
}
