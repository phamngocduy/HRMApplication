using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class ChungChiMap : EntityTypeConfiguration<ChungChi>
    {
        public ChungChiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NoiCap)
                .IsRequired();

            this.Property(t => t.HieuLuc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ChungChi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.LoaiChungChi_id).HasColumnName("LoaiChungChi_id");
            this.Property(t => t.Capdo).HasColumnName("Capdo");
            this.Property(t => t.NoiCap).HasColumnName("NoiCap");
            this.Property(t => t.NgayCap).HasColumnName("NgayCap");
            this.Property(t => t.HieuLuc).HasColumnName("HieuLuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SauKhiVeTruong).HasColumnName("SauKhiVeTruong");
            this.Property(t => t.HoTro).HasColumnName("HoTro");

            // Relationships
            this.HasRequired(t => t.dmLoaichungchi)
                .WithMany(t => t.ChungChis)
                .HasForeignKey(d => d.LoaiChungChi_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.ChungChis)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvQTChungChi)
                .WithMany(t => t.ChungChis)
                .HasForeignKey(d => d.HoTro)
				.WillCascadeOnDelete(false);

        }
    }
}
