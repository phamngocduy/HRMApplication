using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvCTDoanTheTruocMap : EntityTypeConfiguration<nvCTDoanTheTruoc>
    {
        public nvCTDoanTheTruocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ChucVu)
                .IsRequired();

            this.Property(t => t.DonVi)
                .IsRequired();

            this.Property(t => t.NgayBatDau)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NgayKetThuc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvCTDoanTheTruoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.CongTac_id).HasColumnName("CongTac_id");
            this.Property(t => t.ChucVu).HasColumnName("ChucVu");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmCongTacDoanThe)
                .WithMany(t => t.nvCTDoanTheTruocs)
                .HasForeignKey(d => d.CongTac_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvCTDoanTheTruocs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
