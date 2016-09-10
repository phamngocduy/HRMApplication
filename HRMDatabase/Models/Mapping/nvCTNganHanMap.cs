using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvCTNganHanMap : EntityTypeConfiguration<nvCTNganHan>
    {
        public nvCTNganHanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvCTNganHan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CT_id).HasColumnName("CT_id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.KinhPhi).HasColumnName("KinhPhi");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.CongTac)
                .WithMany(t => t.nvCTNganHans)
                .HasForeignKey(d => d.CT_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvCTNganHans)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
