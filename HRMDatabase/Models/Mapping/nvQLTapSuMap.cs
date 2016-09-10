using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQLTapSuMap : EntityTypeConfiguration<nvQLTapSu>
    {
        public nvQLTapSuMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvQLTapSu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CT_id).HasColumnName("CT_id");
            this.Property(t => t.ThoiGianDenHan).HasColumnName("ThoiGianDenHan");
            this.Property(t => t.NgayThongBao).HasColumnName("NgayThongBao");
            this.Property(t => t.NgayNhanHoSo).HasColumnName("NgayNhanHoSo");
            this.Property(t => t.NgayLapToTrinh).HasColumnName("NgayLapToTrinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.CongTac)
                .WithMany(t => t.nvQLTapSus)
                .HasForeignKey(d => d.CT_id)
				.WillCascadeOnDelete(false);

        }
    }
}
