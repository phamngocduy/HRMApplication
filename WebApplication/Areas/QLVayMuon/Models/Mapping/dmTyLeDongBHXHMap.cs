using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class dmTyLeDongBHXHMap : EntityTypeConfiguration<dmTyLeDongBHXH>
    {
        public dmTyLeDongBHXHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DoanhNghiepBHXH)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NguoiLDBHXH)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TongBHXH)
                .HasMaxLength(10);

            this.Property(t => t.DoanhNghiepBHYT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NguoiLDBHYT)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TongBHYT)
                .HasMaxLength(10);

            this.Property(t => t.DoanhNghiepBHTN)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.NguoiLDBHTN)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TongBHTN)
                .HasMaxLength(10);

            this.Property(t => t.TongCong)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("dmTyLeDongBHXH");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NgayApDung).HasColumnName("NgayApDung");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.DoanhNghiepBHXH).HasColumnName("DoanhNghiepBHXH");
            this.Property(t => t.NguoiLDBHXH).HasColumnName("NguoiLDBHXH");
            this.Property(t => t.TongBHXH).HasColumnName("TongBHXH");
            this.Property(t => t.DoanhNghiepBHYT).HasColumnName("DoanhNghiepBHYT");
            this.Property(t => t.NguoiLDBHYT).HasColumnName("NguoiLDBHYT");
            this.Property(t => t.TongBHYT).HasColumnName("TongBHYT");
            this.Property(t => t.DoanhNghiepBHTN).HasColumnName("DoanhNghiepBHTN");
            this.Property(t => t.NguoiLDBHTN).HasColumnName("NguoiLDBHTN");
            this.Property(t => t.TongBHTN).HasColumnName("TongBHTN");
            this.Property(t => t.TongCong).HasColumnName("TongCong");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.STT).HasColumnName("STT");
            this.Property(t => t.SoNgayConLai).HasColumnName("SoNgayConLai");
        }
    }
}
