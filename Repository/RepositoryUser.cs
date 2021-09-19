using Core.Repository;
using Data;
using Domain;
using Repository.Base;

namespace Repository
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly ApplicationContext _context;

        public RepositoryUser(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
