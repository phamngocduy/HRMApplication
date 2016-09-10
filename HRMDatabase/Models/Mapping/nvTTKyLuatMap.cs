using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTKyLuatMap : EntityTypeConfiguration<nvTTKyLuat>
    {
        public nvTTKyLuatMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CapRaQuyetDinh)
                .HasMaxLength(50);

            this.Property(t => t.DonViRaKyLuat)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LyDoKyLuat)
                .HasMaxLength(100);

            this.Property(t => t.MucBoiThuong)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvTTKyLuat");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HinhThuc_id).HasColumnName("HinhThuc_id");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.NgayQuyetDinh).HasColumnName("NgayQuyetDinh");
            this.Property(t => t.CapRaQuyetDinh).HasColumnName("CapRaQuyetDinh");
            this.Property(t => t.DonViRaKyLuat).HasColumnName("DonViRaKyLuat");
            this.Property(t => t.LyDoKyLuat).HasColumnName("LyDoKyLuat");
            this.Property(t => t.MucBoiThuong).HasColumnName("MucBoiThuong");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmHinhThucKyLuat)
                .WithMany(t => t.nvTTKyLuats)
                .HasForeignKey(d => d.HinhThuc_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTKyLuats)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
