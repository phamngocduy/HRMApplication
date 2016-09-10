using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class bcKhoaGiangDayMap : EntityTypeConfiguration<bcKhoaGiangDay>
    {
        public bcKhoaGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("bcKhoaGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NgayBC).HasColumnName("NgayBC");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.Chinh_id).HasColumnName("Chinh_id");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.bcKhoaGiangDays)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.nvNganhGiangDay)
                .WithMany(t => t.bcKhoaGiangDays)
                .HasForeignKey(d => d.Chinh_id)
				.WillCascadeOnDelete(false);

        }
    }
}
