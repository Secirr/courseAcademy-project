using System;
namespace Application.Features.Categories.Commands.Delete
{
	public class DeletedCategoryResponse
	{

		public string Name { get; set; }

		public string Description { get; set; }

		public DateTime DeletedDate { get; set; }

	}
}

