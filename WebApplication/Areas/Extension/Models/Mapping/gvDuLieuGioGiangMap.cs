using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Extension.Databases.Models.Mapping
{
    public class gvDuLieuGioGiangMap : EntityTypeConfiguration<gvDuLieuGioGiang>
    {
        public gvDuLieuGioGiangMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maGV)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChucDanh)
                .HasMaxLength(50);

            this.Property(t => t.HocVi)
                .HasMaxLength(50);

            this.Property(t => t.ChucDanhTrinhDo)
                .HasMaxLength(50);

            this.Property(t => t.MonDay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TietThuc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Lop)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.So)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NhomMH2)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NhomMH3)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NhomMH6)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DonViCongTac)
                .HasMaxLength(10);

            this.Property(t => t.KhoaGiangDay)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NganhGiangDay)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PhanLoaiGV)
                .HasMaxLength(10);

            this.Property(t => t.PhanLoaiGV2)
                .HasMaxLength(10);

            this.Property(t => t.DacCach)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gvDuLieuGioGiang");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.GV_id).HasColumnName("GV_id");
            this.Property(t => t.maGV).HasColumnName("maGV");
            this.Property(t => t.HocKy).HasColumnName("HocKy");
            this.Property(t => t.NamHoc).HasColumnName("NamHoc");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.ChucDanh).HasColumnName("ChucDanh");
            this.Property(t => t.HocVi).HasColumnName("HocVi");
            this.Property(t => t.ChucDanhTrinhDo).HasColumnName("ChucDanhTrinhDo");
            this.Property(t => t.MonDay).HasColumnName("MonDay");
            this.Property(t => t.TietThuc).HasColumnName("TietThuc");
            this.Property(t => t.TietQuyDoi).HasColumnName("TietQuyDoi");
            this.Property(t => t.Lop).HasColumnName("Lop");
            this.Property(t => t.So).HasColumnName("So");
            this.Property(t => t.HeSoChucDanh).HasColumnName("HeSoChucDanh");
            this.Property(t => t.HeSoLopDong).HasColumnName("HeSoLopDong");
            this.Property(t => t.MucChuan).HasColumnName("MucChuan");
            this.Property(t => t.DonGia).HasColumnName("DonGia");
            this.Property(t => t.TongThuLao).HasColumnName("TongThuLao");
            this.Property(t => t.LyThuyet).HasColumnName("LyThuyet");
            this.Property(t => t.ThucHanh).HasColumnName("ThucHanh");
            this.Property(t => t.NhomMH2).HasColumnName("NhomMH2");
            this.Property(t => t.NhomMH3).HasColumnName("NhomMH3");
            this.Property(t => t.NhomMH6).HasColumnName("NhomMH6");
            this.Property(t => t.DonViCongTac).HasColumnName("DonViCongTac");
            this.Property(t => t.KhoaGiangDay).HasColumnName("KhoaGiangDay");
            this.Property(t => t.NganhGiangDay).HasColumnName("NganhGiangDay");
            this.Property(t => t.PhanLoaiGV).HasColumnName("PhanLoaiGV");
            this.Property(t => t.PhanLoaiGV2).HasColumnName("PhanLoaiGV2");
            this.Property(t => t.DacCach).HasColumnName("DacCach");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.ThoiGian).HasColumnName("ThoiGian");
            this.Property(t => t.nvNganhGiangDay_id).HasColumnName("nvNganhGiangDay_id");
        }
    }
}
