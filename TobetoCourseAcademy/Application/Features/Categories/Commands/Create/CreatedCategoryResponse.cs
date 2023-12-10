using System;
namespace Application.Features.Categories.Commands.Create
{
	public class CreatedCategoryResponse //kulanıcıya gösterilen alan
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public DateTime CreatedDate { get; set; }

	}
}

