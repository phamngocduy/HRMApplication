using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTNghiNganHanMap : EntityTypeConfiguration<nvQTNghiNganHan>
    {
        public nvQTNghiNganHanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("nvQTNghiNganHan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CT_id).HasColumnName("CT_id");
            this.Property(t => t.LoaiNghi_id).HasColumnName("LoaiNghi_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmLoaiNghiNganHan)
                .WithMany(t => t.nvQTNghiNganHans)
                .HasForeignKey(d => d.LoaiNghi_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.CongTac)
                .WithMany(t => t.nvQTNghiNganHans)
                .HasForeignKey(d => d.CT_id)
				.WillCascadeOnDelete(false);

        }
    }
}
