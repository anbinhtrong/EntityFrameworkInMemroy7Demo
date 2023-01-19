using DatabaseInMemoryExample.Models;

namespace DatabaseInMemoryExample.Repositories
{
	public interface IAuthorRepository
	{
		public List<AuthorModel> GetAuthors(int pageSize, int page);
	}
}
