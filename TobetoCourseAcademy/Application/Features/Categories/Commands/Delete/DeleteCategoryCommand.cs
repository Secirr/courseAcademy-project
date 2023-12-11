using System;
using MediatR;

namespace Application.Features.Categories.Commands.Delete
{
	public class DeleteCategoryCommand : IRequest<DeletedCategoryResponse>
	{

		public string Name { get; set; }

		public string Description { get; set; }


	}
}

