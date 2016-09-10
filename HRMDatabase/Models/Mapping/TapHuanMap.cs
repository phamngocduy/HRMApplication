using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class TapHuanMap : EntityTypeConfiguration<TapHuan>
    {
        public TapHuanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.TenKhoaTH)
                .HasMaxLength(150);

            this.Property(t => t.NoiDung)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SoLuotThamGia)
                .HasMaxLength(50);

            this.Property(t => t.KinhPhi)
                .HasMaxLength(50);

            this.Property(t => t.DiaDiem)
                .HasMaxLength(150);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TapHuan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.TenKhoaTH).HasColumnName("TenKhoaTH");
            this.Property(t => t.NoiDung).HasColumnName("NoiDung");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.SoLuotThamGia).HasColumnName("SoLuotThamGia");
            this.Property(t => t.KinhPhi).HasColumnName("KinhPhi");
            this.Property(t => t.DiaDiem).HasColumnName("DiaDiem");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
        }
    }
}
