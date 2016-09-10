using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiQuyetDinhMap : EntityTypeConfiguration<dmLoaiQuyetDinh>
    {
        public dmLoaiQuyetDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiQuyetDinh)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiQuyetDinh)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dmLoaiQuyetDinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.maLoaiQuyetDinh).HasColumnName("maLoaiQuyetDinh");
            this.Property(t => t.tenLoaiQuyetDinh).HasColumnName("tenLoaiQuyetDinh");
            this.Property(t => t.stt).HasColumnName("stt");
        }
    }
}
