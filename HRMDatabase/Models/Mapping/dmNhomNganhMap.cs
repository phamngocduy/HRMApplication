using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNhomNganhMap : EntityTypeConfiguration<dmNhomNganh>
    {
        public dmNhomNganhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maNhomNganh)
                .HasMaxLength(10);

            this.Property(t => t.tenNhomNganh)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("dmNhomNganh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maNhomNganh).HasColumnName("maNhomNganh");
            this.Property(t => t.tenNhomNganh).HasColumnName("tenNhomNganh");
        }
    }
}
