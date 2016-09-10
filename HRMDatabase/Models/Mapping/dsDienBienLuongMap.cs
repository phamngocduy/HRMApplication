using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsDienBienLuongMap : EntityTypeConfiguration<dsDienBienLuong>
    {
        public dsDienBienLuongMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.NgayBatDau, t.ThoiGianGiuBac, t.HeSoLuong, t.PhuCap, t.User_id, t.HienTai });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ThoiGianGiuBac)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.PhuCap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LyDoThayDoi)
                .HasMaxLength(50);

            this.Property(t => t.User_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.maNhomNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNhomNgachVienChuc)
                .HasMaxLength(50);

            this.Property(t => t.maNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNgachVienChuc)
                .HasMaxLength(60);

            this.Property(t => t.G_SoQuyetDinh)
                .HasMaxLength(50);

            this.Property(t => t.G_LyDoThayDoi)
                .HasMaxLength(50);

            this.Property(t => t.G_tenLoaiThayDoi)
                .HasMaxLength(50);

            this.Property(t => t.HienTai)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("dsDienBienLuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.ThoiGianGiuBac).HasColumnName("ThoiGianGiuBac");
            this.Property(t => t.NhomNgach_id).HasColumnName("NhomNgach_id");
            this.Property(t => t.Ngach_id).HasColumnName("Ngach_id");
            this.Property(t => t.BacLuong).HasColumnName("BacLuong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.LyDoThayDoi).HasColumnName("LyDoThayDoi");
            this.Property(t => t.User_id).HasColumnName("User_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.KetThucDuKien).HasColumnName("KetThucDuKien");
            this.Property(t => t.maNhomNgachVienChuc).HasColumnName("maNhomNgachVienChuc");
            this.Property(t => t.tenNhomNgachVienChuc).HasColumnName("tenNhomNgachVienChuc");
            this.Property(t => t.maNgachVienChuc).HasColumnName("maNgachVienChuc");
            this.Property(t => t.tenNgachVienChuc).HasColumnName("tenNgachVienChuc");
            this.Property(t => t.G_id).HasColumnName("G_id");
            this.Property(t => t.G_SoThangThayDoi).HasColumnName("G_SoThangThayDoi");
            this.Property(t => t.G_SoQuyetDinh).HasColumnName("G_SoQuyetDinh");
            this.Property(t => t.G_LyDoThayDoi).HasColumnName("G_LyDoThayDoi");
            this.Property(t => t.G_tenLoaiThayDoi).HasColumnName("G_tenLoaiThayDoi");
            this.Property(t => t.HienTai).HasColumnName("HienTai");
        }
    }
}
