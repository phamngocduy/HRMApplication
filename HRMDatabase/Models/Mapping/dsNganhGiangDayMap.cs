using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsNganhGiangDayMap : EntityTypeConfiguration<dsNganhGiangDay>
    {
        public dsNganhGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.NganhGiangDay, t.ThoiGianBatDau, t.KhoaGiangDay, t.idNganhGiangDay, t.idKhoaGiangDay });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NganhGiangDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KhoaGiangDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.idNganhGiangDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idKhoaGiangDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.maNganhGiangDay)
                .HasMaxLength(10);

            this.Property(t => t.tenNganhGiangDay)
                .HasMaxLength(50);

            this.Property(t => t.maKhoaGiangDay)
                .HasMaxLength(10);

            this.Property(t => t.tenKhoaGiangDay)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dsNganhGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NganhGiangDay).HasColumnName("NganhGiangDay");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.KhoaGiangDay).HasColumnName("KhoaGiangDay");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.idNganhGiangDay).HasColumnName("idNganhGiangDay");
            this.Property(t => t.idKhoaGiangDay).HasColumnName("idKhoaGiangDay");
            this.Property(t => t.maNganhGiangDay).HasColumnName("maNganhGiangDay");
            this.Property(t => t.tenNganhGiangDay).HasColumnName("tenNganhGiangDay");
            this.Property(t => t.sttNganhGiangDay).HasColumnName("sttNganhGiangDay");
            this.Property(t => t.maKhoaGiangDay).HasColumnName("maKhoaGiangDay");
            this.Property(t => t.tenKhoaGiangDay).HasColumnName("tenKhoaGiangDay");
            this.Property(t => t.sttKhoaGiangDay).HasColumnName("sttKhoaGiangDay");
            this.Property(t => t.LaChinh).HasColumnName("LaChinh");
        }
    }
}
