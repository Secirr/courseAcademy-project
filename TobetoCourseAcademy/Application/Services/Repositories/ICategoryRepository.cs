using System;
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
	public interface ICategoryRepository : IRepository<Category, Guid>, IAsyncRepository<Category, Guid>
	{
		
	}
}

