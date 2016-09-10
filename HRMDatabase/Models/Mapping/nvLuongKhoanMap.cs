using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvLuongKhoanMap : EntityTypeConfiguration<nvLuongKhoan>
    {
        public nvLuongKhoanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nvLuongKhoan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.BatDau).HasColumnName("BatDau");
            this.Property(t => t.KetThuc).HasColumnName("KetThuc");
            this.Property(t => t.SoTien).HasColumnName("SoTien");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvLuongKhoans)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
