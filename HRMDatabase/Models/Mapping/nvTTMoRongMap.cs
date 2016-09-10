using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTMoRongMap : EntityTypeConfiguration<nvTTMoRong>
    {
        public nvTTMoRongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvTTMoRong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThamNienGiangDay_Truoc).HasColumnName("ThamNienGiangDay_Truoc");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTMoRongs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
