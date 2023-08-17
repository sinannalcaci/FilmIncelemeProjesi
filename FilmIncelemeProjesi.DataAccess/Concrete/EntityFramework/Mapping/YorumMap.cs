using FilmIncelemeProjesi.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Mapping
{
    public class YorumMap : IEntityTypeConfiguration<Yorum>
    {
        public void Configure(EntityTypeBuilder<Yorum> builder)
        {
            builder.ToTable("Yorum");
            builder.Property(u => u.Content).HasMaxLength(500).IsRequired();
            

            //Yorum İle Film ilişki
           builder.HasOne(y=>y.Film).WithMany(f=>f.Yorums).HasForeignKey(y=>y.FilmId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
