using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsTTKhenThuongMap : EntityTypeConfiguration<dsTTKhenThuong>
    {
        public dsTTKhenThuongMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.NgayQuyetDinh, t.CapKhenThuong, t.NoiDungKhenThuong });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.CapKhenThuong)
                .IsRequired();

            this.Property(t => t.NoiDungKhenThuong)
                .IsRequired();

            this.Property(t => t.MucKhenThuong)
                .HasMaxLength(50);

            this.Property(t => t.maHinhThucKhenThuong)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.tenHinhThucKhenThuong)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsTTKhenThuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayQuyetDinh).HasColumnName("NgayQuyetDinh");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.HinhThuc_id).HasColumnName("HinhThuc_id");
            this.Property(t => t.CapKhenThuong).HasColumnName("CapKhenThuong");
            this.Property(t => t.NoiDungKhenThuong).HasColumnName("NoiDungKhenThuong");
            this.Property(t => t.MucKhenThuong).HasColumnName("MucKhenThuong");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.maHinhThucKhenThuong).HasColumnName("maHinhThucKhenThuong");
            this.Property(t => t.tenHinhThucKhenThuong).HasColumnName("tenHinhThucKhenThuong");
            this.Property(t => t.sttHinhThucKhenThuong).HasColumnName("sttHinhThucKhenThuong");
        }
    }
}
