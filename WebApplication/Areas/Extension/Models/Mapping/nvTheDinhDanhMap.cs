using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Extension.Databases.Models.Mapping
{
    public class nvTheDinhDanhMap : EntityTypeConfiguration<nvTheDinhDanh>
    {
        public nvTheDinhDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoThe)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("nvTheDinhDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.LoaiThe_id).HasColumnName("LoaiThe_id");
            this.Property(t => t.SoThe).HasColumnName("SoThe");
            this.Property(t => t.NgayCap).HasColumnName("NgayCap");
            this.Property(t => t.NoiCap_id).HasColumnName("NoiCap_id");
            this.Property(t => t.NgayHetHan).HasColumnName("NgayHetHan");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTheDinhDanhs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
