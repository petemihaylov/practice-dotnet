using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowBasket.Core.IRepositories;
using ShowBasket.Data;

namespace ShowBasket.Core.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<User>> All()
        {
            return await dbSet.ToListAsync();
        }

        public override async Task<bool> Delete(Guid id)
        {
            var exist = await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(exist == null)return false;

            dbSet.Remove(exist);
            return true;
        }

        public override async Task<bool> Upsert(User entity)
        {
            var existingUser = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            if(existingUser == null) return await Add(entity);

            existingUser.FirstName = entity.FirstName;
            existingUser.LastName = entity.LastName;
            existingUser.Email = entity.Email;

            return true;
        }
    }
}