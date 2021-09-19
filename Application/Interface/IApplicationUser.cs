using DTO;
using System;

namespace Application.Interface
{
    public interface IApplicationUser
    {
        UserDTO GetById(Guid id);
        UserDTO GetOnlyActive();

        void Add(UserDTO obj);

        void Update(UserDTO obj);

        void Delete(UserDTO obj);
        
    }
}
