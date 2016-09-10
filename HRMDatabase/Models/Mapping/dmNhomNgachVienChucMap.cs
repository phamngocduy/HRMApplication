using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNhomNgachVienChucMap : EntityTypeConfiguration<dmNhomNgachVienChuc>
    {
        public dmNhomNgachVienChucMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.maNhomNgachVienChuc)
                .HasMaxLength(10);

            this.Property(t => t.tenNhomNgachVienChuc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmNhomNgachVienChuc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.bangLuong).HasColumnName("bangLuong");
            this.Property(t => t.maNhomNgachVienChuc).HasColumnName("maNhomNgachVienChuc");
            this.Property(t => t.tenNhomNgachVienChuc).HasColumnName("tenNhomNgachVienChuc");
        }
    }
}
