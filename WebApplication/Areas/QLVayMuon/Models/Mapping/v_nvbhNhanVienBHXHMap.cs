using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class v_nvbhNhanVienBHXHMap : EntityTypeConfiguration<v_nvbhNhanVienBHXH>
    {
        public v_nvbhNhanVienBHXHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaBV)
                .HasMaxLength(10);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(100);

            this.Property(t => t.MANV)
                .HasMaxLength(50);

            this.Property(t => t.DiaChiTT)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            this.Property(t => t.TinhTrang)
                .HasMaxLength(5);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            this.Property(t => t.chucdanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("v_nvbhNhanVienBHXH");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.diachi).HasColumnName("diachi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ngayNghiViec).HasColumnName("ngayNghiViec");
            this.Property(t => t.MaBV).HasColumnName("MaBV");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.SoThangThamGiaBHXH).HasColumnName("SoThangThamGiaBHXH");
            this.Property(t => t.SoNamThamGiaBHXH).HasColumnName("SoNamThamGiaBHXH");
            this.Property(t => t.ThoiGianThamGiaBHXHTaiTruong).HasColumnName("ThoiGianThamGiaBHXHTaiTruong");
            this.Property(t => t.MANV).HasColumnName("MANV");
            this.Property(t => t.Nu).HasColumnName("Nu");
            this.Property(t => t.CMND).HasColumnName("CMND");
            this.Property(t => t.DiaChiTT).HasColumnName("DiaChiTT");
            this.Property(t => t.SoBHXH).HasColumnName("SoBHXH");
            this.Property(t => t.SoKCB).HasColumnName("SoKCB");
            this.Property(t => t.iddmNoiKCB).HasColumnName("iddmNoiKCB");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.Donvi_id).HasColumnName("Donvi_id");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.TG_BD_TS).HasColumnName("TG_BD_TS");
            this.Property(t => t.TG_KT_TS).HasColumnName("TG_KT_TS");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SoNamThamGiaBHXHTruocVeTruong).HasColumnName("SoNamThamGiaBHXHTruocVeTruong");
            this.Property(t => t.SoNamThamGiaBHTNTruocVeTruong).HasColumnName("SoNamThamGiaBHTNTruocVeTruong");
            this.Property(t => t.SoThangThamGiaBHTNTruocVeTruong).HasColumnName("SoThangThamGiaBHTNTruocVeTruong");
            this.Property(t => t.SoNamThamGiaBHTNT).HasColumnName("SoNamThamGiaBHTNT");
            this.Property(t => t.SoThangThamGiaBHTN).HasColumnName("SoThangThamGiaBHTN");
            this.Property(t => t.ThoiGianThamGiaBHTNTaiTruong).HasColumnName("ThoiGianThamGiaBHTNTaiTruong");
            this.Property(t => t.TinhTrang).HasColumnName("TinhTrang");
            this.Property(t => t.SoThangThamGiaBHXHTruocVeTruong).HasColumnName("SoThangThamGiaBHXHTruocVeTruong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.sothangBHTN).HasColumnName("sothangBHTN");
            this.Property(t => t.sonamBHTN).HasColumnName("sonamBHTN");
            this.Property(t => t.sothangBHXH).HasColumnName("sothangBHXH");
            this.Property(t => t.sonamBHXH).HasColumnName("sonamBHXH");
            this.Property(t => t.ThangNghiTS).HasColumnName("ThangNghiTS");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.chucdanh).HasColumnName("chucdanh");
        }
    }
}
