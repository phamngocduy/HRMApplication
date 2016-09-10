using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsTTKyLuatMap : EntityTypeConfiguration<dsTTKyLuat>
    {
        public dsTTKyLuatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.HinhThuc_id, t.SoQuyetDinh, t.NgayQuyetDinh, t.DonViRaKyLuat });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HinhThuc_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.maHinhThucKyLuat)
                .HasMaxLength(10);

            this.Property(t => t.tenHinhThucKyLuat)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsTTKyLuat");
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
            this.Property(t => t.maHinhThucKyLuat).HasColumnName("maHinhThucKyLuat");
            this.Property(t => t.tenHinhThucKyLuat).HasColumnName("tenHinhThucKyLuat");
            this.Property(t => t.sttHinhThucKyLuat).HasColumnName("sttHinhThucKyLuat");
        }
    }
}
