using AutoMapper;
using Dws.Note_One.Api.Resources;
using Dws.Note_One.Api.Domain.Models;

namespace Dws.Note_One.Api.Extensions
{

    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveUserResouce, User>();
        }
    }

}