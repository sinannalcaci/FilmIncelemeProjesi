using FilmIncelemeProjesi.DataAccess.Abstract;
using FilmIncelemeProjesi.DataAccess.Abstract.DataManagement;
using FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Context;
using FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.DataManagement;
using FilmIncelemeProjesi.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework
{
    public class EfUserRepository : EfRepository<User>, IUserRepository
    {
        public EfUserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
