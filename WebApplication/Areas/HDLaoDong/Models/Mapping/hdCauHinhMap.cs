using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class hdCauHinhMap : EntityTypeConfiguration<hdCauHinh>
    {
        public hdCauHinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HotenNSDLD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Coquan)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Diachi)
                .IsRequired();

            this.Property(t => t.SDT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mucluongchinh)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Cosotienluong)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.DiadiemLV)
                .IsRequired();

            this.Property(t => t.MLTTChung1)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MLTTChung2)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("hdCauHinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HotenNSDLD).HasColumnName("HotenNSDLD");
            this.Property(t => t.Quoctich_id).HasColumnName("Quoctich_id");
            this.Property(t => t.Chucvu_id).HasColumnName("Chucvu_id");
            this.Property(t => t.Coquan).HasColumnName("Coquan");
            this.Property(t => t.Diachi).HasColumnName("Diachi");
            this.Property(t => t.SDT).HasColumnName("SDT");
            this.Property(t => t.Mucluongchinh).HasColumnName("Mucluongchinh");
            this.Property(t => t.Cosotienluong).HasColumnName("Cosotienluong");
            this.Property(t => t.DiadiemLV).HasColumnName("DiadiemLV");
            this.Property(t => t.NgayHDTV).HasColumnName("NgayHDTV");
            this.Property(t => t.NgayHDCT).HasColumnName("NgayHDCT");
            this.Property(t => t.Gioitinh_id).HasColumnName("Gioitinh_id");
            this.Property(t => t.MLTTChung1).HasColumnName("MLTTChung1");
            this.Property(t => t.MLTTChung2).HasColumnName("MLTTChung2");
        }
    }
}
