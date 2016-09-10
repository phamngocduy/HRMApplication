using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChuyenNganhMap : EntityTypeConfiguration<dmChuyenNganh>
    {
        public dmChuyenNganhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChuyenNganh)
                .HasMaxLength(50);

            this.Property(t => t.tenChuyenNganh)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("dmChuyenNganh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maChuyenNganh).HasColumnName("maChuyenNganh");
            this.Property(t => t.tenChuyenNganh).HasColumnName("tenChuyenNganh");
        }
    }
}
