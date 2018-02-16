using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/foo")]
	public class FooController : BaseGenericController<Foo>
	{
		public FooController(IFooRepository repository) : base(repository) { }
	}
}
