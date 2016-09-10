using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiNghiNganHanMap : EntityTypeConfiguration<dmLoaiNghiNganHan>
    {
        public dmLoaiNghiNganHanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiNghiNganHan)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiNghiNganHan)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiNghiNganHan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiNghiNganHan).HasColumnName("maLoaiNghiNganHan");
            this.Property(t => t.tenLoaiNghiNganHan).HasColumnName("tenLoaiNghiNganHan");
            this.Property(t => t.tinhThamNien).HasColumnName("tinhThamNien");
            this.Property(t => t.khongHuongLuong).HasColumnName("khongHuongLuong");
        }
    }
}
