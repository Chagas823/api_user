using Dws.Note_One.Api.Domain.Models;


namespace Dws.Note_One.Api.Domain.Repositories.IRepositories{
    public interface IUnitOfWork{
        Task CompleteAsync();
    }
}