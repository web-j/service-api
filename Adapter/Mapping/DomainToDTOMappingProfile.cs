using AutoMapper;
using Domain;
using DTO;

namespace Adapter.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
