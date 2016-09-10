using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsQLHoSoHSLMap : EntityTypeConfiguration<dsQLHoSoHSL>
    {
        public dsQLHoSoHSLMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.HSL_id, t.HoanThanh, t.HeSoLuong, t.PhuCap, t.ThoiGianGiuBac });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HSL_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.PhuCap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ThoiGianGiuBac)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.HSL_BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.maNhomNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNhomNgachVienChuc)
                .HasMaxLength(50);

            this.Property(t => t.maNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNgachVienChuc)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("dsQLHoSoHSL");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HSL_id).HasColumnName("HSL_id");
            this.Property(t => t.BanTuNhanXet).HasColumnName("BanTuNhanXet");
            this.Property(t => t.BienBanHopDonVi).HasColumnName("BienBanHopDonVi");
            this.Property(t => t.DeXuatTruongDonVi).HasColumnName("DeXuatTruongDonVi");
            this.Property(t => t.HoanThanh).HasColumnName("HoanThanh");
            this.Property(t => t.BacLuong).HasColumnName("BacLuong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.ThoiGianGiuBac).HasColumnName("ThoiGianGiuBac");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HSL_ThoiGianDenHan).HasColumnName("HSL_ThoiGianDenHan");
            this.Property(t => t.HSL_BacLuong).HasColumnName("HSL_BacLuong");
            this.Property(t => t.HSL_HeSoLuong).HasColumnName("HSL_HeSoLuong");
            this.Property(t => t.HSL_PhuCap).HasColumnName("HSL_PhuCap");
            this.Property(t => t.NhomNgach_id).HasColumnName("NhomNgach_id");
            this.Property(t => t.Ngach_id).HasColumnName("Ngach_id");
            this.Property(t => t.maNhomNgachVienChuc).HasColumnName("maNhomNgachVienChuc");
            this.Property(t => t.tenNhomNgachVienChuc).HasColumnName("tenNhomNgachVienChuc");
            this.Property(t => t.maNgachVienChuc).HasColumnName("maNgachVienChuc");
            this.Property(t => t.tenNgachVienChuc).HasColumnName("tenNgachVienChuc");
        }
    }
}
