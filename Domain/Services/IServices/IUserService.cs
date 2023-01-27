using Dws.Note_One.Api.Domain.Models;
using Dws.Note_One.Api.Services.Communication;
namespace Dws.Note_One.Api.Domain.Services.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
    }
}