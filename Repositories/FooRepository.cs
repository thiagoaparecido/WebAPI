using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class FooRepository : GenericRepository<Foo>, IFooRepository
    {
        public FooRepository(WebAPIContext context) : base(context)
        {
        }
    }
}
