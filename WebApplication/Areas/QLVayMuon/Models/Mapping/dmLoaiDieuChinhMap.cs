using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class dmLoaiDieuChinhMap : EntityTypeConfiguration<dmLoaiDieuChinh>
    {
        public dmLoaiDieuChinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.LoaiDieuChinh)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmLoaiDieuChinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LoaiDieuChinh).HasColumnName("LoaiDieuChinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.STT).HasColumnName("STT");
        }
    }
}
