using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiKhoaHocMap : EntityTypeConfiguration<dmLoaiKhoaHoc>
    {
        public dmLoaiKhoaHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiKhoaHoc)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiKhoaHoc)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("dmLoaiKhoaHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiKhoaHoc).HasColumnName("maLoaiKhoaHoc");
            this.Property(t => t.tenLoaiKhoaHoc).HasColumnName("tenLoaiKhoaHoc");
        }
    }
}
