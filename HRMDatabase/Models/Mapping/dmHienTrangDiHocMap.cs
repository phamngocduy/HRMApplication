using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHienTrangDiHocMap : EntityTypeConfiguration<dmHienTrangDiHoc>
    {
        public dmHienTrangDiHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHienTrangDiHoc)
                .HasMaxLength(20);

            this.Property(t => t.tenHienTrangDiHoc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHienTrangDiHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.maHienTrangDiHoc).HasColumnName("maHienTrangDiHoc");
            this.Property(t => t.tenHienTrangDiHoc).HasColumnName("tenHienTrangDiHoc");
            this.Property(t => t.stt).HasColumnName("stt");
        }
    }
}
