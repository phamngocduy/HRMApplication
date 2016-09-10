using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHinhThucKhenThuongMap : EntityTypeConfiguration<dmHinhThucKhenThuong>
    {
        public dmHinhThucKhenThuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHinhThucKhenThuong)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.tenHinhThucKhenThuong)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHinhThucKhenThuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maHinhThucKhenThuong).HasColumnName("maHinhThucKhenThuong");
            this.Property(t => t.tenHinhThucKhenThuong).HasColumnName("tenHinhThucKhenThuong");
        }
    }
}
