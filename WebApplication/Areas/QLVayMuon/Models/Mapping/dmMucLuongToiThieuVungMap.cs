using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class dmMucLuongToiThieuVungMap : EntityTypeConfiguration<dmMucLuongToiThieuVung>
    {
        public dmMucLuongToiThieuVungMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ThuocVung)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmMucLuongToiThieuVung");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.MucLuong).HasColumnName("MucLuong");
            this.Property(t => t.ThuocVung).HasColumnName("ThuocVung");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.STT).HasColumnName("STT");
            this.Property(t => t.SoNgayConLai).HasColumnName("SoNgayConLai");
            this.Property(t => t.MucLuongCaoHonTrungCap).HasColumnName("MucLuongCaoHonTrungCap");
        }
    }
}
