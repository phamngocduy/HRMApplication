using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsCTDoanTheMap : EntityTypeConfiguration<dsCTDoanThe>
    {
        public dsCTDoanTheMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.NgayBatDau, t.ChucVu_id });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NoiKetNap)
                .HasMaxLength(100);

            this.Property(t => t.ChiBo)
                .HasMaxLength(50);

            this.Property(t => t.ChucVu_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maChucVuDoanThe)
                .HasMaxLength(10);

            this.Property(t => t.tenChucVuDoanThe)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsCTDoanThe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayVaoDuBi).HasColumnName("NgayVaoDuBi");
            this.Property(t => t.NgayVaoChinhThuc).HasColumnName("NgayVaoChinhThuc");
            this.Property(t => t.NoiKetNap).HasColumnName("NoiKetNap");
            this.Property(t => t.ChiBo).HasColumnName("ChiBo");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.ChucVu_id).HasColumnName("ChucVu_id");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.sttChucVuDoanThe).HasColumnName("sttChucVuDoanThe");
            this.Property(t => t.maChucVuDoanThe).HasColumnName("maChucVuDoanThe");
            this.Property(t => t.tenChucVuDoanThe).HasColumnName("tenChucVuDoanThe");
        }
    }
}
