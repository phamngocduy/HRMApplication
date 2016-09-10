using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsDiaChiNhaMap : EntityTypeConfiguration<dsDiaChiNha>
    {
        public dsDiaChiNhaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maPhuongXa)
                .HasMaxLength(10);

            this.Property(t => t.tenPhuongXa)
                .HasMaxLength(50);

            this.Property(t => t.maQuanHuyen)
                .HasMaxLength(10);

            this.Property(t => t.tenQuanHuyen)
                .HasMaxLength(50);

            this.Property(t => t.maTinhThanh)
                .HasMaxLength(10);

            this.Property(t => t.tenTinhThanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsDiaChiNha");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DiaChi).HasColumnName("DiaChi");
            this.Property(t => t.PhuongXa_id).HasColumnName("PhuongXa_id");
            this.Property(t => t.QuanHuyen_id).HasColumnName("QuanHuyen_id");
            this.Property(t => t.TinhThanh_id).HasColumnName("TinhThanh_id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.sttPhuongXa).HasColumnName("sttPhuongXa");
            this.Property(t => t.maPhuongXa).HasColumnName("maPhuongXa");
            this.Property(t => t.tenPhuongXa).HasColumnName("tenPhuongXa");
            this.Property(t => t.sttQuanHuyen).HasColumnName("sttQuanHuyen");
            this.Property(t => t.maQuanHuyen).HasColumnName("maQuanHuyen");
            this.Property(t => t.tenQuanHuyen).HasColumnName("tenQuanHuyen");
            this.Property(t => t.sttTinhThanh).HasColumnName("sttTinhThanh");
            this.Property(t => t.maTinhThanh).HasColumnName("maTinhThanh");
            this.Property(t => t.tenTinhThanh).HasColumnName("tenTinhThanh");
        }
    }
}
