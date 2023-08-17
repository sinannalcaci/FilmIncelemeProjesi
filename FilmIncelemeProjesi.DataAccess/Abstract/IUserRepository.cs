using FilmIncelemeProjesi.DataAccess.Abstract.DataManagement;
using FilmIncelemeProjesi.Entity.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.DataAccess.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
    }
}
