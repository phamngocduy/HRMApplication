using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class hdPhuLucHD2Map : EntityTypeConfiguration<hdPhuLucHD2>
    {
        public hdPhuLucHD2Map()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HSLuong)
                .HasMaxLength(10);

            this.Property(t => t.Mucluongtoithieu)
                .HasMaxLength(15);

            this.Property(t => t.CSTienluong)
                .HasMaxLength(15);

            this.Property(t => t.HSCDCM)
                .HasMaxLength(10);

            this.Property(t => t.HSNhiemvu)
                .HasMaxLength(10);

            this.Property(t => t.HSThamnien)
                .HasMaxLength(10);

            this.Property(t => t.HSKLCV1)
                .HasMaxLength(10);

            this.Property(t => t.HSSLSV2)
                .HasMaxLength(10);

            this.Property(t => t.HSHQCVdonvi)
                .HasMaxLength(10);

            this.Property(t => t.HSHQCVcanhan)
                .HasMaxLength(10);

            this.Property(t => t.Thulao)
                .HasMaxLength(15);

            this.Property(t => t.Thunhap)
                .HasMaxLength(15);

            this.Property(t => t.HQCV)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("hdPhuLucHD2");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HD_id).HasColumnName("HD_id");
            this.Property(t => t.NgaylapPL).HasColumnName("NgaylapPL");
            this.Property(t => t.HSLuong).HasColumnName("HSLuong");
            this.Property(t => t.Mucluongtoithieu).HasColumnName("Mucluongtoithieu");
            this.Property(t => t.CSTienluong).HasColumnName("CSTienluong");
            this.Property(t => t.HSCDCM).HasColumnName("HSCDCM");
            this.Property(t => t.HSNhiemvu).HasColumnName("HSNhiemvu");
            this.Property(t => t.HSThamnien).HasColumnName("HSThamnien");
            this.Property(t => t.HSKLCV1).HasColumnName("HSKLCV1");
            this.Property(t => t.HSSLSV2).HasColumnName("HSSLSV2");
            this.Property(t => t.HSHQCVdonvi).HasColumnName("HSHQCVdonvi");
            this.Property(t => t.HSHQCVcanhan).HasColumnName("HSHQCVcanhan");
            this.Property(t => t.Thulao).HasColumnName("Thulao");
            this.Property(t => t.Thunhap).HasColumnName("Thunhap");
            this.Property(t => t.Ghichu).HasColumnName("Ghichu");
            this.Property(t => t.Daky).HasColumnName("Daky");
            this.Property(t => t.HQCV).HasColumnName("HQCV");

            // Relationships
            this.HasRequired(t => t.hdChiTietHDLD)
                .WithMany(t => t.hdPhuLucHD2)
                .HasForeignKey(d => d.HD_id)
				.WillCascadeOnDelete(false);

        }
    }
}
