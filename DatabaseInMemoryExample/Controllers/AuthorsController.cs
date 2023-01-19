using DatabaseInMemoryExample.Models;
using DatabaseInMemoryExample.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseInMemoryExample.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorsController : ControllerBase
	{
		private readonly IAuthorRepository _authorRepository;
		public AuthorsController(IAuthorRepository authorRepository)
		{
			_authorRepository = authorRepository;
		}
		[HttpGet]
		public ActionResult<List<Author>> Get(int pageSize, int pageIndex)
		{
			return Ok(_authorRepository.GetAuthors(pageSize, pageIndex));
		}
	}
}
