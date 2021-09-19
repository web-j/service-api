using Core.Repository;
using Core.Service;
using Domain;
using Service.Base;

namespace Service
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        public readonly IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser) : base(repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public User GetOnlyActive()
        {
            return _repositoryUser.Get(p => p.EStatusType == 0);
        }
    }
}
