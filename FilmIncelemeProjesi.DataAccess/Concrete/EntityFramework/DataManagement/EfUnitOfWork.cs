using FilmIncelemeProjesi.DataAccess.Abstract;
using FilmIncelemeProjesi.DataAccess.Abstract.DataManagement;
using FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.Context;
using FilmIncelemeProjesi.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.DataAccess.Concrete.EntityFramework.DataManagement
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EfUnitOfWork(AppDbContext context)
        {
            _context = context;
            UserRepository = new EfUserRepository(_context);
            FilmRepository = new EfFilmRepository(_context);
            YorumRepository = new EfYorumRepository(_context);
        }

        public IUserRepository UserRepository { get; } 

        public IFilmRepository FilmRepository { get; }

        public IYorumRepository YorumRepository { get; }

        public async Task<int> SaveChangeAsync()
        {
            foreach (var item in _context.ChangeTracker.Entries<BaseEntity>())
            {
                if (item.State == EntityState.Added)
                {
                    
                    if (item.Entity.IsActive == null)
                    {
                        item.Entity.IsActive = true;
                    }

                    item.Entity.IsDeleted = false;
                }
                else if (item.State == EntityState.Modified)
                {
                    
                }
            }

            return await _context.SaveChangesAsync();
        }
    }
}
