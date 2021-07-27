using System.Threading.Tasks;
using PocketBook.Core.IRepositories;

namespace PocketBook.Core.IConfiguration 
{
    public interface IUnitOfWork 
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
        
    }
}