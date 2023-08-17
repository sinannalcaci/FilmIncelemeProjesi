using FilmIncelemeProjesi.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(u=>u.UserName).HasMaxLength(50).IsRequired();
            builder.Property(u=>u.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(50).IsRequired();

            //User ile Film İlişki
            builder.HasMany(u => u.Films).WithOne(f => f.User).HasForeignKey(f=>f.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
