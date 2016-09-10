using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class HoanVayMap : EntityTypeConfiguration<HoanVay>
    {
        public HoanVayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoChungTu)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DienGiai)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.MaNV)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("HoanVay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idKhoanVay).HasColumnName("idKhoanVay");
            this.Property(t => t.SoChungTu).HasColumnName("SoChungTu");
            this.Property(t => t.NgayChungTu).HasColumnName("NgayChungTu");
            this.Property(t => t.DienGiai).HasColumnName("DienGiai");
            this.Property(t => t.SoTienHoan).HasColumnName("SoTienHoan");
            this.Property(t => t.SoTienLai).HasColumnName("SoTienLai");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.IdNV).HasColumnName("IdNV");

            // Relationships
            this.HasOptional(t => t.KhoanVay)
                .WithMany(t => t.HoanVays)
                .HasForeignKey(d => d.idKhoanVay)
				.WillCascadeOnDelete(true);

        }
    }
}
