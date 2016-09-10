using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvKhoaGiangDayMap : EntityTypeConfiguration<nvKhoaGiangDay>
    {
        public nvKhoaGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvKhoaGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.KhoaGiangDay).HasColumnName("KhoaGiangDay");

            // Relationships
            this.HasRequired(t => t.dmKhoaGiangDay)
                .WithMany(t => t.nvKhoaGiangDays)
                .HasForeignKey(d => d.KhoaGiangDay)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvKhoaGiangDays)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
