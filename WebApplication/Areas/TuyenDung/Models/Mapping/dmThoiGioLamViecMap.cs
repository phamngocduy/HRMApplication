using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class dmThoiGioLamViecMap : EntityTypeConfiguration<dmThoiGioLamViec>
    {
        public dmThoiGioLamViecMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenThoiGioLamViec)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dmThoiGioLamViec");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.tenThoiGioLamViec).HasColumnName("tenThoiGioLamViec");
        }
    }
}
