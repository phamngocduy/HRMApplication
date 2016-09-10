using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class nvbhLaiTruyThuBHMap : EntityTypeConfiguration<nvbhLaiTruyThuBH>
    {
        public nvbhLaiTruyThuBHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("nvbhLaiTruyThuBH");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.iddmLaiSuatTruyThu).HasColumnName("iddmLaiSuatTruyThu");
            this.Property(t => t.iddmMucLuongToiThieuChung).HasColumnName("iddmMucLuongToiThieuChung");
            this.Property(t => t.idnvbhNhanVienBHXH).HasColumnName("idnvbhNhanVienBHXH");
            this.Property(t => t.iddmTyLeDongBHXH).HasColumnName("iddmTyLeDongBHXH");
            this.Property(t => t.TienLuongHoacChenhLechTienLuong).HasColumnName("TienLuongHoacChenhLechTienLuong");
            this.Property(t => t.TuThangNam).HasColumnName("TuThangNam");
            this.Property(t => t.DenThangNam).HasColumnName("DenThangNam");
            this.Property(t => t.SoThangTruyThu).HasColumnName("SoThangTruyThu");
            this.Property(t => t.TongThoiGianChamDong).HasColumnName("TongThoiGianChamDong");
            this.Property(t => t.TienLaiTruyThuBHXH).HasColumnName("TienLaiTruyThuBHXH");
            this.Property(t => t.TienLaiTruyThuBHTN).HasColumnName("TienLaiTruyThuBHTN");
            this.Property(t => t.TienLaiTruyThuBHYT).HasColumnName("TienLaiTruyThuBHYT");
            this.Property(t => t.TongCong).HasColumnName("TongCong");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmLaiSuatTruyThu)
                .WithMany(t => t.nvbhLaiTruyThuBHs)
                .HasForeignKey(d => d.iddmLaiSuatTruyThu);
            this.HasRequired(t => t.dmMucLuongToiThieuChung)
                .WithMany(t => t.nvbhLaiTruyThuBHs)
                .HasForeignKey(d => d.iddmMucLuongToiThieuChung);
            this.HasRequired(t => t.dmTyLeDongBHXH)
                .WithMany(t => t.nvbhLaiTruyThuBHs)
                .HasForeignKey(d => d.iddmTyLeDongBHXH);
            this.HasRequired(t => t.nvbhNhanVienBHXH)
                .WithMany(t => t.nvbhLaiTruyThuBHs)
                .HasForeignKey(d => d.idnvbhNhanVienBHXH);

        }
    }
}
