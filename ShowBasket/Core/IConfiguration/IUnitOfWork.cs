using System.Threading.Tasks;
using ShowBasket.Core.IRepositories;

namespace ShowBasket.Core.IConfiguration
{
   public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}