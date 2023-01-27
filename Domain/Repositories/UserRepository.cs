using Microsoft.EntityFrameworkCore;
using Dws.Note_One.Api.Domain.Models;
using Dws.Note_One.Api.Domain.Repositories.IRepositories;
using Dws.Note_One.Api.Persistence.Contexts;

namespace Dws.Note_One.Api.Domain.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public void Update(User user)
        {
            _context.Users.Update(user);
        }

        public void Remove(User user)
        {
            _context.Users.Remove(user);
        }

    }
}
