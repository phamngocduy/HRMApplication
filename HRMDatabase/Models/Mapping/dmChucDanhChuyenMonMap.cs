using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChucDanhChuyenMonMap : EntityTypeConfiguration<dmChucDanhChuyenMon>
    {
        public dmChucDanhChuyenMonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChucDanhChuyenMon)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhChuyenMon)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmChucDanhChuyenMon");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maChucDanhChuyenMon).HasColumnName("maChucDanhChuyenMon");
            this.Property(t => t.tenChucDanhChuyenMon).HasColumnName("tenChucDanhChuyenMon");
            this.Property(t => t.laDayHoc).HasColumnName("laDayHoc");
            this.Property(t => t.qlTapSu).HasColumnName("qlTapSu");
        }
    }
}
