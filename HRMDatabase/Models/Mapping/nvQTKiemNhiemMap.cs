using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTKiemNhiemMap : EntityTypeConfiguration<nvQTKiemNhiem>
    {
        public nvQTKiemNhiemMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.PhuCap)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("nvQTKiemNhiem");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.CongViec).HasColumnName("CongViec");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmDonVi)
                .WithMany(t => t.nvQTKiemNhiems)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvQTKiemNhiems)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
