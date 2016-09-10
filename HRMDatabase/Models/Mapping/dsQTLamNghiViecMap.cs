using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsQTLamNghiViecMap : EntityTypeConfiguration<dsQTLamNghiViec>
    {
        public dsQTLamNghiViecMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.ThoiGianBatDau });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(10);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.N_SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.N_GhiChu)
                .HasMaxLength(150);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            this.Property(t => t.maChucDanh)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanh)
                .HasMaxLength(50);

            this.Property(t => t.maChucDanhChuyenMon)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhChuyenMon)
                .HasMaxLength(50);

            this.Property(t => t.maNgheNghiep)
                .HasMaxLength(10);

            this.Property(t => t.tenNgheNghiep)
                .HasMaxLength(50);

            this.Property(t => t.maLoaiNghiNganHan)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiNghiNganHan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsQTLamNghiViec");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.ChucDanh_id).HasColumnName("ChucDanh_id");
            this.Property(t => t.ChucDanhChucVu_id).HasColumnName("ChucDanhChucVu_id");
            this.Property(t => t.NgheNghiep_id).HasColumnName("NgheNghiep_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.ChucVu_id).HasColumnName("ChucVu_id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.N_id).HasColumnName("N_id");
            this.Property(t => t.LoaiNghi_id).HasColumnName("LoaiNghi_id");
            this.Property(t => t.N_NgayBatDau).HasColumnName("N_NgayBatDau");
            this.Property(t => t.N_NgayKetThuc).HasColumnName("N_NgayKetThuc");
            this.Property(t => t.N_SoQuyetDinh).HasColumnName("N_SoQuyetDinh");
            this.Property(t => t.N_GhiChu).HasColumnName("N_GhiChu");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.sttDonVi).HasColumnName("sttDonVi");
            this.Property(t => t.maChucDanh).HasColumnName("maChucDanh");
            this.Property(t => t.tenChucDanh).HasColumnName("tenChucDanh");
            this.Property(t => t.sttChucDanh).HasColumnName("sttChucDanh");
            this.Property(t => t.maChucDanhChuyenMon).HasColumnName("maChucDanhChuyenMon");
            this.Property(t => t.tenChucDanhChuyenMon).HasColumnName("tenChucDanhChuyenMon");
            this.Property(t => t.qlTapSu).HasColumnName("qlTapSu");
            this.Property(t => t.sttChucDanhChuyenMon).HasColumnName("sttChucDanhChuyenMon");
            this.Property(t => t.maNgheNghiep).HasColumnName("maNgheNghiep");
            this.Property(t => t.tenNgheNghiep).HasColumnName("tenNgheNghiep");
            this.Property(t => t.sttNgheNghiep).HasColumnName("sttNgheNghiep");
            this.Property(t => t.maLoaiNghiNganHan).HasColumnName("maLoaiNghiNganHan");
            this.Property(t => t.tenLoaiNghiNganHan).HasColumnName("tenLoaiNghiNganHan");
            this.Property(t => t.khongHuongLuong).HasColumnName("khongHuongLuong");
            this.Property(t => t.tinhThamNien).HasColumnName("tinhThamNien");
            this.Property(t => t.sttLoaiNghiNganHan).HasColumnName("sttLoaiNghiNganHan");
            this.Property(t => t.HienTai).HasColumnName("HienTai");
        }
    }
}
