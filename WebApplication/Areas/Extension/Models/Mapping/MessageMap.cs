using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Extension.Databases.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Content)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Users).HasColumnName("Users");
            this.Property(t => t.Read).HasColumnName("Read");
            this.Property(t => t.Star).HasColumnName("Star");
        }
    }
}
