using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNgachVienChucMap : EntityTypeConfiguration<dmNgachVienChuc>
    {
        public dmNgachVienChucMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNgachVienChuc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("dmNgachVienChuc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maNgachVienChuc).HasColumnName("maNgachVienChuc");
            this.Property(t => t.tenNgachVienChuc).HasColumnName("tenNgachVienChuc");
            this.Property(t => t.nhomNgachVienChuc).HasColumnName("nhomNgachVienChuc");

            // Relationships
            this.HasRequired(t => t.dmNhomNgachVienChuc)
                .WithMany(t => t.dmNgachVienChucs)
                .HasForeignKey(d => d.nhomNgachVienChuc)
				.WillCascadeOnDelete(false);

        }
    }
}
