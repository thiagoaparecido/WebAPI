using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/foo")]
	public class FooController : BaseGenericController<Foo>
	{
		public FooController(IFooRepository repository, ILogger<Foo> logger) : base(repository, logger) { }
	}
}
