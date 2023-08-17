using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.DataAccess.Abstract.DataManagement
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IFilmRepository FilmRepository { get; }
        IYorumRepository YorumRepository { get; }


        Task<int> SaveChangeAsync();
    }

}
