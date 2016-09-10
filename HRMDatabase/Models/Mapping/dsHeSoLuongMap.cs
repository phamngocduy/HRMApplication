using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsHeSoLuongMap : EntityTypeConfiguration<dsHeSoLuong>
    {
        public dsHeSoLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.N_id);

            // Properties
            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.LyDoThayDoi)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.N_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.maChucDanh)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsHeSoLuong");
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
            this.Property(t => t.ThoiGianDenHan).HasColumnName("ThoiGianDenHan");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.N_id).HasColumnName("N_id");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.maChucDanh).HasColumnName("maChucDanh");
            this.Property(t => t.tenChucDanh).HasColumnName("tenChucDanh");
            this.Property(t => t.ngayNghiViec).HasColumnName("ngayNghiViec");
        }
    }
}
