using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class nvbhQuaTrinhBHXHMap : EntityTypeConfiguration<nvbhQuaTrinhBHXH>
    {
        public nvbhQuaTrinhBHXHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.GhiChu1)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu2)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("nvbhQuaTrinhBHXH");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idNVBHXH).HasColumnName("idNVBHXH");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.MucLuongDongBHXH).HasColumnName("MucLuongDongBHXH");
            this.Property(t => t.MucLuongDongBHTN).HasColumnName("MucLuongDongBHTN");
            this.Property(t => t.MucDongBHXH).HasColumnName("MucDongBHXH");
            this.Property(t => t.MucDongBHTN).HasColumnName("MucDongBHTN");
            this.Property(t => t.HeSoTienLuongDongBHXH).HasColumnName("HeSoTienLuongDongBHXH");
            this.Property(t => t.MucDongToiThieu).HasColumnName("MucDongToiThieu");
            this.Property(t => t.GhiChu1).HasColumnName("GhiChu1");
            this.Property(t => t.GhiChu2).HasColumnName("GhiChu2");
            this.Property(t => t.NV_ID).HasColumnName("NV_ID");
            this.Property(t => t.TG_ID).HasColumnName("TG_ID");
            this.Property(t => t.TienLuong).HasColumnName("TienLuong");
            this.Property(t => t.HSL).HasColumnName("HSL");
            this.Property(t => t.SoNamNghiBHXH).HasColumnName("SoNamNghiBHXH");
            this.Property(t => t.SoThangNghiBHXH).HasColumnName("SoThangNghiBHXH");
            this.Property(t => t.TongMucDongBHXH).HasColumnName("TongMucDongBHXH");
            this.Property(t => t.TongMucDongBHTN).HasColumnName("TongMucDongBHTN");
            this.Property(t => t.TongMucDongBHYT).HasColumnName("TongMucDongBHYT");
            this.Property(t => t.Hide).HasColumnName("Hide");
        }
    }
}
