using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLThinhGiang.Models.Mapping
{
    public class DiaPhuongMap : EntityTypeConfiguration<DiaPhuong>
    {
        public DiaPhuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("DiaPhuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.PhuongXa_id).HasColumnName("PhuongXa_id");
            this.Property(t => t.QuanHuyen_id).HasColumnName("QuanHuyen_id");
            this.Property(t => t.TinhThanh_id).HasColumnName("TinhThanh_id");
        }
    }
}
