using AutoMapper;
using Domain;
using DTO;

namespace Adapter.Mapping
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<UserDTO, User>();
        }
    }
}
