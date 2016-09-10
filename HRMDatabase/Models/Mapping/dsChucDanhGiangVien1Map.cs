using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsChucDanhGiangVien1Map : EntityTypeConfiguration<dsChucDanhGiangVien1>
    {
        public dsChucDanhGiangVien1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.ChucDanh_id, t.NgayBatDau });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChucDanh_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maChucDanhGiangVien)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhGiangVien)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsChucDanhGiangVien1");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ChucDanh_id).HasColumnName("ChucDanh_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.maChucDanhGiangVien).HasColumnName("maChucDanhGiangVien");
            this.Property(t => t.tenChucDanhGiangVien).HasColumnName("tenChucDanhGiangVien");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
            this.Property(t => t.sttChucDanhGiangVien).HasColumnName("sttChucDanhGiangVien");
            this.Property(t => t.stt).HasColumnName("stt");
        }
    }
}
