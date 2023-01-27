using AutoMapper;
using Dws.Note_One.Api.Domain.Models;
using Dws.Note_One.Api.Resources;

namespace Dws.Note_One.Api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<User, UserResource>();
        }
    }
}