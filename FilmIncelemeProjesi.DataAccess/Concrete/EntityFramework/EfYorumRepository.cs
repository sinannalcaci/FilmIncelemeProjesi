using FilmIncelemeProjesi.DataAccess.Abstract;
using FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Context;
using FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.DataManagement;
using FilmIncelemeProjesi.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework
{
    public class EfYorumRepository : EfRepository<Yorum>, IYorumRepository
    {
        public EfYorumRepository(AppDbContext context) : base(context)
        {
        }
    }
}
