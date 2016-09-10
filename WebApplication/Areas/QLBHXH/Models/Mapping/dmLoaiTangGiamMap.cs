using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class dmLoaiTangGiamMap : EntityTypeConfiguration<dmLoaiTangGiam>
    {
        public dmLoaiTangGiamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Ma)
                .HasMaxLength(10);

            this.Property(t => t.LoaiTangGiam)
                .HasMaxLength(100);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmLoaiTangGiam");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Ma).HasColumnName("Ma");
            this.Property(t => t.LoaiTangGiam).HasColumnName("LoaiTangGiam");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.STT).HasColumnName("STT");
            this.Property(t => t.idLoaiDieuChinh).HasColumnName("idLoaiDieuChinh");

            // Relationships
            this.HasOptional(t => t.dmLoaiDieuChinh)
                .WithMany(t => t.dmLoaiTangGiams)
                .HasForeignKey(d => d.idLoaiDieuChinh)
				.WillCascadeOnDelete(false);

        }
    }
}
