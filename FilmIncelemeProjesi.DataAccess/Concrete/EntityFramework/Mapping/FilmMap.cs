using FilmIncelemeProjesi.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Mapping
{
    public class FilmMap : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Film");
            builder.Property(u => u.Name).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Category).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Description).HasMaxLength(1000).IsRequired();
            builder.Property(u => u.DateTime);

           
           
        }
    }
}
