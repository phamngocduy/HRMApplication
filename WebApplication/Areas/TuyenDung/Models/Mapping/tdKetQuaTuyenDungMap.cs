using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdKetQuaTuyenDungMap : EntityTypeConfiguration<tdKetQuaTuyenDung>
    {
        public tdKetQuaTuyenDungMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.KetQuaTuyenDung)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("tdKetQuaTuyenDung");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.KetQuaTuyenDung).HasColumnName("KetQuaTuyenDung");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdKetQuaTuyenDungs)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
