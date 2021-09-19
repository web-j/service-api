using Application.Interface;
using AutoMapper;
using Core.Service;
using Domain;
using DTO;
using System;

namespace Application.Service
{
    public class ApplicationUser : IApplicationUser
    {

        private readonly IMapper _mapper;
        private readonly IServiceUser _serviceUser;

        public ApplicationUser(IServiceUser serviceUser, IMapper mapper)
        {
            _serviceUser = serviceUser;
            _mapper = mapper;
        }

        public void Add(UserDTO obj)
        {
            var newUser = _mapper.Map<User>(obj);
            _serviceUser.Add(newUser);
        }

        public void Delete(UserDTO obj)
        {
            var newUser = _mapper.Map<User>(obj);
            _serviceUser.Remove(newUser);
        }

        public UserDTO GetById(Guid id)
        {
            return _mapper.Map<UserDTO>(_serviceUser.GetById(id));            
        }

        public UserDTO GetOnlyActive()
        {
            return _mapper.Map<UserDTO>(_serviceUser.GetOnlyActive());
        }

        public void Update(UserDTO obj)
        {
            var newUser = _mapper.Map<User>(obj);
            _serviceUser.Update(newUser);
        }
    }
}
