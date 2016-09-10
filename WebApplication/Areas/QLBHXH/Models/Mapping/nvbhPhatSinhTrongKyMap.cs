using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class nvbhPhatSinhTrongKyMap : EntityTypeConfiguration<nvbhPhatSinhTrongKy>
    {
        public nvbhPhatSinhTrongKyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvbhPhatSinhTrongKy");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.KyBaoCao).HasColumnName("KyBaoCao");
            this.Property(t => t.BHXH_SLD_Tang).HasColumnName("BHXH_SLD_Tang");
            this.Property(t => t.BHXH_SLD_Giam).HasColumnName("BHXH_SLD_Giam");
            this.Property(t => t.BHYT_SLD_Tang).HasColumnName("BHYT_SLD_Tang");
            this.Property(t => t.BHYT_SLD_Giam).HasColumnName("BHYT_SLD_Giam");
            this.Property(t => t.BHTN_SLD_Tang).HasColumnName("BHTN_SLD_Tang");
            this.Property(t => t.BHTN_SLD_Giam).HasColumnName("BHTN_SLD_Giam");
            this.Property(t => t.BHXH_QL_Tang).HasColumnName("BHXH_QL_Tang");
            this.Property(t => t.BHXH_QL_Giam).HasColumnName("BHXH_QL_Giam");
            this.Property(t => t.BHYT_QL_Tang).HasColumnName("BHYT_QL_Tang");
            this.Property(t => t.BHYT_QL_Giam).HasColumnName("BHYT_QL_Giam");
            this.Property(t => t.BHTN_QL_Tang).HasColumnName("BHTN_QL_Tang");
            this.Property(t => t.BHTN_QL_Giam).HasColumnName("BHTN_QL_Giam");
            this.Property(t => t.BHXH_SPD_Tang).HasColumnName("BHXH_SPD_Tang");
            this.Property(t => t.BHXH_SPD_Giam).HasColumnName("BHXH_SPD_Giam");
            this.Property(t => t.BHYT_SPD_Tang).HasColumnName("BHYT_SPD_Tang");
            this.Property(t => t.BHYT_SPD_Giam).HasColumnName("BHYT_SPD_Giam");
            this.Property(t => t.BHTN_SPD_Tang).HasColumnName("BHTN_SPD_Tang");
            this.Property(t => t.BHTN_SPD_Giam).HasColumnName("BHTN_SPD_Giam");
            this.Property(t => t.BHXH_DC_Tang).HasColumnName("BHXH_DC_Tang");
            this.Property(t => t.BHXH_DC_Giam).HasColumnName("BHXH_DC_Giam");
            this.Property(t => t.BHYT_DC_Tang).HasColumnName("BHYT_DC_Tang");
            this.Property(t => t.BHYT_DC_Giam).HasColumnName("BHYT_DC_Giam");
            this.Property(t => t.BHTN_DC_Tang).HasColumnName("BHTN_DC_Tang");
            this.Property(t => t.BHTN_DC_Giam).HasColumnName("BHTN_DC_Giam");
        }
    }
}
