using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChucDanhGiangVienMap : EntityTypeConfiguration<dmChucDanhGiangVien>
    {
        public dmChucDanhGiangVienMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChucDanhGiangVien)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhGiangVien)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmChucDanhGiangVien");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maChucDanhGiangVien).HasColumnName("maChucDanhGiangVien");
            this.Property(t => t.tenChucDanhGiangVien).HasColumnName("tenChucDanhGiangVien");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
        }
    }
}
