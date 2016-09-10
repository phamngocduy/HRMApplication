using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHangThuongBinhMap : EntityTypeConfiguration<dmHangThuongBinh>
    {
        public dmHangThuongBinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHangThuongBinh)
                .HasMaxLength(10);

            this.Property(t => t.tenHangThuongBinh)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHangThuongBinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maHangThuongBinh).HasColumnName("maHangThuongBinh");
            this.Property(t => t.tenHangThuongBinh).HasColumnName("tenHangThuongBinh");
        }
    }
}
