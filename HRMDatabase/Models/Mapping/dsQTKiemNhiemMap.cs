using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsQTKiemNhiemMap : EntityTypeConfiguration<dsQTKiemNhiem>
    {
        public dsQTKiemNhiemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.ThoiGianBatDau, t.DonVi_id });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DonVi_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhuCap)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(100);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dsQTKiemNhiem");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.CongViec).HasColumnName("CongViec");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.sttDonVi).HasColumnName("sttDonVi");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
        }
    }
}
