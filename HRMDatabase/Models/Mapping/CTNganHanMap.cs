using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class CTNganHanMap : EntityTypeConfiguration<CTNganHan>
    {
        public CTNganHanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CTNganHan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LoaiCT_id).HasColumnName("LoaiCT_id");
            this.Property(t => t.NoiDung).HasColumnName("NoiDung");
            this.Property(t => t.DiaDiem).HasColumnName("DiaDiem");
            this.Property(t => t.NuocNgoai).HasColumnName("NuocNgoai");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.NgayCapQuyetDinh).HasColumnName("NgayCapQuyetDinh");
            this.Property(t => t.KinhPhiHoTro).HasColumnName("KinhPhiHoTro");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.LoaiCongTac)
                .WithMany(t => t.CTNganHans)
                .HasForeignKey(d => d.LoaiCT_id)
				.WillCascadeOnDelete(false);

        }
    }
}
