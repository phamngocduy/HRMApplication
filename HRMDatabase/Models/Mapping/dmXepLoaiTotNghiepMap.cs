using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmXepLoaiTotNghiepMap : EntityTypeConfiguration<dmXepLoaiTotNghiep>
    {
        public dmXepLoaiTotNghiepMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maXepLoaiTotNghiep)
                .HasMaxLength(10);

            this.Property(t => t.tenXepLoaiTotNghiep)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("dmXepLoaiTotNghiep");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maXepLoaiTotNghiep).HasColumnName("maXepLoaiTotNghiep");
            this.Property(t => t.tenXepLoaiTotNghiep).HasColumnName("tenXepLoaiTotNghiep");
        }
    }
}
