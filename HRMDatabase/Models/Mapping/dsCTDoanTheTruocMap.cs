using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsCTDoanTheTruocMap : EntityTypeConfiguration<dsCTDoanTheTruoc>
    {
        public dsCTDoanTheTruocMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.CongTac_id, t.ChucVu, t.DonVi, t.NgayBatDau });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CongTac_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChucVu)
                .IsRequired();

            this.Property(t => t.DonVi)
                .IsRequired();

            this.Property(t => t.NgayBatDau)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NgayKetThuc)
                .HasMaxLength(50);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maCongTacDoanThe)
                .HasMaxLength(10);

            this.Property(t => t.tenCongTacDoanThe)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsCTDoanTheTruoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.CongTac_id).HasColumnName("CongTac_id");
            this.Property(t => t.ChucVu).HasColumnName("ChucVu");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.maCongTacDoanThe).HasColumnName("maCongTacDoanThe");
            this.Property(t => t.tenCongTacDoanThe).HasColumnName("tenCongTacDoanThe");
            this.Property(t => t.sttCongTacDoanThe).HasColumnName("sttCongTacDoanThe");
        }
    }
}
