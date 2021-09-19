using Core.Service.Base;
using Domain;

namespace Core.Service
{
    public interface IServiceUser : IServiceBase<User>
    {
        User GetOnlyActive();
    }
}
