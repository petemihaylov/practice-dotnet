using System;
using System.Threading.Tasks;
using ShowBasket.Core.IConfiguration;
using ShowBasket.Core.IRepositories;
using ShowBasket.Core.Repositories;

namespace ShowBasket.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            this.Users = new UserRepository(context);
        }

        public IUserRepository Users { get; init; }


        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}