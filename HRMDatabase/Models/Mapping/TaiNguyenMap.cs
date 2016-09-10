using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class TaiNguyenMap : EntityTypeConfiguration<TaiNguyen>
    {
        public TaiNguyenMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenTaiNguyen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tepDinhKem)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TaiNguyen");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idTaiNguyen).HasColumnName("idTaiNguyen");
            this.Property(t => t.tenTaiNguyen).HasColumnName("tenTaiNguyen");
            this.Property(t => t.tepDinhKem).HasColumnName("tepDinhKem");
            this.Property(t => t.laThuMuc).HasColumnName("laThuMuc");

            // Relationships
            this.HasOptional(t => t.chaTaiNguyen)
                .WithMany(t => t.TaiNguyen1)
                .HasForeignKey(d => d.idTaiNguyen)
				.WillCascadeOnDelete(false);

        }
    }
}
