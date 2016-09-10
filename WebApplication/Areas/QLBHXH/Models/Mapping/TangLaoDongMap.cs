using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class TangLaoDongMap : EntityTypeConfiguration<TangLaoDong>
    {
        public TangLaoDongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TangLaoDong");
            this.Property(t => t.Ngaybd).HasColumnName("Ngaybd");
            this.Property(t => t.Ngaykt).HasColumnName("Ngaykt");
            this.Property(t => t.MLTTC).HasColumnName("MLTTC");
            this.Property(t => t.MLTTV).HasColumnName("MLTTV");
            this.Property(t => t.TLBHXH).HasColumnName("TLBHXH");
            this.Property(t => t.TLBHYT).HasColumnName("TLBHYT");
            this.Property(t => t.TLBHTN).HasColumnName("TLBHTN");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
