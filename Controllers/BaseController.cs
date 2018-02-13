using System;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
public abstract class BaseGenericController<T> : Controller
	{
		protected IRepository<T> repository;

		public BaseGenericController(IRepository<T> repository)
		{
			this.repository = repository;
		}

		[HttpGet]
		public IActionResult FindAll()
		{
			var result = repository.FindAll();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public IActionResult Find(long id)
		{
			var result = repository.Find(id);
			return Ok(result);
		}

        [HttpPost]
        public IActionResult Create([FromBody] T obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repository.Add(obj);
            return Ok(obj);
        }

		[HttpPut("{id}")]
		public IActionResult Update(long id, [FromBody] T obj)
		{
			if (obj == null)
			{
				return BadRequest();
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			repository.Update(id, obj);
			return new NoContentResult();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			repository.Remove(id);
			return Ok();
		}
	}
}