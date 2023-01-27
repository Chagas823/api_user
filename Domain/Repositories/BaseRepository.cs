using Dws.Note_One.Api.Persistence.Contexts;

namespace Dws.Note_One.Api.Domain.Repositories{
    public abstract class BaseRepository{
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context){
           _context = context;     
        }
    }
}