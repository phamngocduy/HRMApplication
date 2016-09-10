using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdBangCapMap : EntityTypeConfiguration<tdBangCap>
    {
        public tdBangCapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NoiDaoTao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tdBangCap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.TrinhDo_id).HasColumnName("TrinhDo_id");
            this.Property(t => t.ChuyenNganh_id).HasColumnName("ChuyenNganh_id");
            this.Property(t => t.NoiDaoTao).HasColumnName("NoiDaoTao");
            this.Property(t => t.NamTotNghiep).HasColumnName("NamTotNghiep");
            this.Property(t => t.XepLoai_id).HasColumnName("XepLoai_id");
            this.Property(t => t.SetDefault).HasColumnName("SetDefault");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdBangCaps)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
