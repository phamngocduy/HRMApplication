using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTapHuanMap : EntityTypeConfiguration<nvTapHuan>
    {
        public nvTapHuanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvTapHuan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.BuoiTapHuan_id).HasColumnName("BuoiTapHuan_id");
            this.Property(t => t.CoThamGia).HasColumnName("CoThamGia");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTapHuans)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
