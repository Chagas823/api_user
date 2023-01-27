using Dws.Note_One.Api.Domain.Repositories.IRepositories;
using Dws.Note_One.Api.Persistence.Contexts;

namespace Dws.Note_One.Api.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}