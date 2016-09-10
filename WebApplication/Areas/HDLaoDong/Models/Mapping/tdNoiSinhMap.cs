using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdNoiSinhMap : EntityTypeConfiguration<tdNoiSinh>
    {
        public tdNoiSinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tdNoiSinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.TinhThanh_id).HasColumnName("TinhThanh_id");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdNoiSinhs)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
