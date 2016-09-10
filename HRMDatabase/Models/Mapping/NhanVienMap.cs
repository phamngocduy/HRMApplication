using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class NhanVienMap : EntityTypeConfiguration<NhanVien>
    {
        public NhanVienMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
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

            this.Property(t => t.qtlvSoQDNghiViec)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("NhanVien");
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

            // Relationships
            this.HasOptional(t => t.nvDiaChiNhaKT3)
                .WithMany(t => t.NhanViens)
                .HasForeignKey(d => d.ttlhDCTamTruKT3_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvHeSoLuong)
                .WithMany(t => t.NhanViens)
                .HasForeignKey(d => d.qltlHeSoLuong_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvNganhGiangDay)
                .WithMany(t => t.NhanViens)
                .HasForeignKey(d => d.nvNganhGiangDay_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvQTLamViec)
                .WithMany(t => t.NhanViens)
                .HasForeignKey(d => d.qtlvCongTac_id)
				.WillCascadeOnDelete(false);

        }
    }
}
