using Dws.Note_One.Api.Domain.Models;

namespace Dws.Note_One.Api.Domain.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task AddAsync(User user);
        Task<User> FindByIdAsync(int id);
        void Update(User user);

        void Remove(User user);

    }
}