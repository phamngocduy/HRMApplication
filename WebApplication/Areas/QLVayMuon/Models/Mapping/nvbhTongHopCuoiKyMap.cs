using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class nvbhTongHopCuoiKyMap : EntityTypeConfiguration<nvbhTongHopCuoiKy>
    {
        public nvbhTongHopCuoiKyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvbhTongHopCuoiKy");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.KyBaoCao).HasColumnName("KyBaoCao");
            this.Property(t => t.BHXH_SLD_Truoc).HasColumnName("BHXH_SLD_Truoc");
            this.Property(t => t.BHXH_SLD_Nay).HasColumnName("BHXH_SLD_Nay");
            this.Property(t => t.BHYT_SLD_Truoc).HasColumnName("BHYT_SLD_Truoc");
            this.Property(t => t.BHYT_SLD_Nay).HasColumnName("BHYT_SLD_Nay");
            this.Property(t => t.BHTN_SLD_Truoc).HasColumnName("BHTN_SLD_Truoc");
            this.Property(t => t.BHTN_SLD_Nay).HasColumnName("BHTN_SLD_Nay");
            this.Property(t => t.BHXH_QL_Truoc).HasColumnName("BHXH_QL_Truoc");
            this.Property(t => t.BHXH_QL_Nay).HasColumnName("BHXH_QL_Nay");
            this.Property(t => t.BHYT_QL_Truoc).HasColumnName("BHYT_QL_Truoc");
            this.Property(t => t.BHYT_QL_Nay).HasColumnName("BHYT_QL_Nay");
            this.Property(t => t.BHTN_QL_Truoc).HasColumnName("BHTN_QL_Truoc");
            this.Property(t => t.BHTN_QL_Nay).HasColumnName("BHTN_QL_Nay");
            this.Property(t => t.BHXH_SPD_Truoc).HasColumnName("BHXH_SPD_Truoc");
            this.Property(t => t.BHXH_SPD_Nay).HasColumnName("BHXH_SPD_Nay");
            this.Property(t => t.BHYT_SPD_Truoc).HasColumnName("BHYT_SPD_Truoc");
            this.Property(t => t.BHYT_SPD_Nay).HasColumnName("BHYT_SPD_Nay");
            this.Property(t => t.BHTN_SPD_Truoc).HasColumnName("BHTN_SPD_Truoc");
            this.Property(t => t.BHTN_SPD_Nay).HasColumnName("BHTN_SPD_Nay");
        }
    }
}
