using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmBangLuongMap : EntityTypeConfiguration<dmBangLuong>
    {
        public dmBangLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.bacLuong)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("dmBangLuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.idNhomNgach).HasColumnName("idNhomNgach");
            this.Property(t => t.bacLuong).HasColumnName("bacLuong");
            this.Property(t => t.hesoLuong).HasColumnName("hesoLuong");
            this.Property(t => t.phuCap).HasColumnName("phuCap");
            this.Property(t => t.soThang).HasColumnName("soThang");

            // Relationships
            this.HasRequired(t => t.dmNhomNgachVienChuc)
                .WithMany(t => t.dmBangLuongs)
                .HasForeignKey(d => d.idNhomNgach)
				.WillCascadeOnDelete(false);

        }
    }
}
