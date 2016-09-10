using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvHocHamMap : EntityTypeConfiguration<nvHocHam>
    {
        public nvHocHamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvHocHam");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HocHam_id).HasColumnName("HocHam_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");

            // Relationships
            this.HasRequired(t => t.dmHocHam)
                .WithMany(t => t.nvHocHams)
                .HasForeignKey(d => d.HocHam_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvHocHams)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
