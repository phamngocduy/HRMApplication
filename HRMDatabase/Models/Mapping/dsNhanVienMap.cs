using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsNhanVienMap : EntityTypeConfiguration<dsNhanVien>
    {
        public dsNhanVienMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.MaNV, t.laNVMoi, t.qtlvThamNienGiangDayT });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaHS)
                .HasMaxLength(10);

            this.Property(t => t.MaTD)
                .HasMaxLength(10);

            this.Property(t => t.MaTV)
                .HasMaxLength(10);

            this.Property(t => t.MaNV)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MaST)
                .HasMaxLength(20);

            this.Property(t => t.ttlhDTNhaRieng)
                .HasMaxLength(20);

            this.Property(t => t.ttlhDTDiDong)
                .HasMaxLength(20);

            this.Property(t => t.ttlhEmailTruong)
                .HasMaxLength(50);

            this.Property(t => t.ttlhEmailKhac)
                .HasMaxLength(100);

            this.Property(t => t.qtlvThamNienGiangDayT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.qtlvSoQDNghiViec)
                .HasMaxLength(20);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dsNhanVien");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MaHS).HasColumnName("MaHS");
            this.Property(t => t.MaTD).HasColumnName("MaTD");
            this.Property(t => t.MaTV).HasColumnName("MaTV");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.MaST).HasColumnName("MaST");
            this.Property(t => t.laNVMoi).HasColumnName("laNVMoi");
            this.Property(t => t.ngayNghiViec).HasColumnName("ngayNghiViec");
            this.Property(t => t.ttlhDTNhaRieng).HasColumnName("ttlhDTNhaRieng");
            this.Property(t => t.ttlhDTDiDong).HasColumnName("ttlhDTDiDong");
            this.Property(t => t.ttlhEmailTruong).HasColumnName("ttlhEmailTruong");
            this.Property(t => t.ttlhEmailKhac).HasColumnName("ttlhEmailKhac");
            this.Property(t => t.ttlhDCTamTruKT3_id).HasColumnName("ttlhDCTamTruKT3_id");
            this.Property(t => t.qtlvThamNienGiangDayT).HasColumnName("qtlvThamNienGiangDayT");
            this.Property(t => t.qtlvCongTac_id).HasColumnName("qtlvCongTac_id");
            this.Property(t => t.qltlHeSoLuong_id).HasColumnName("qltlHeSoLuong_id");
            this.Property(t => t.qtlvSoQDNghiViec).HasColumnName("qtlvSoQDNghiViec");
            this.Property(t => t.nvNganhGiangDay_id).HasColumnName("nvNganhGiangDay_id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.sttDonVi).HasColumnName("sttDonVi");
        }
    }
}
