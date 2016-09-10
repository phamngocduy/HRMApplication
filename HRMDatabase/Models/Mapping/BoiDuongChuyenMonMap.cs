using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class BoiDuongChuyenMonMap : EntityTypeConfiguration<BoiDuongChuyenMon>
    {
        public BoiDuongChuyenMonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TenTruong)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SoQD)
                .HasMaxLength(20);

            this.Property(t => t.GhiChu)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("BoiDuongChuyenMon");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.TenTruong).HasColumnName("TenTruong");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.BatDau).HasColumnName("BatDau");
            this.Property(t => t.HoanThanh).HasColumnName("HoanThanh");
            this.Property(t => t.SoQD).HasColumnName("SoQD");
            this.Property(t => t.NgayCapQD).HasColumnName("NgayCapQD");
            this.Property(t => t.KinhPhi).HasColumnName("KinhPhi");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmDonVi)
                .WithMany(t => t.BoiDuongChuyenMons)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmNoiHoc)
                .WithMany(t => t.BoiDuongChuyenMons)
                .HasForeignKey(d => d.NoiHoc_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmQuocGia)
                .WithMany(t => t.BoiDuongChuyenMons)
                .HasForeignKey(d => d.QuocGia_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.BoiDuongChuyenMons)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
