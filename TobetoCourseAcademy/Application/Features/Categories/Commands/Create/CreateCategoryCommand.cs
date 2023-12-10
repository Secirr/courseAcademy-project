using System;
using MediatR;

namespace Application.Features.Categories.Commands.Create //kulanıcıdan hangi veriler istenecek(Sweager)
{
	public class CreateCategoryCommand : IRequest<CreatedCategoryResponse>
	{

		public string Name { get; set; } 

		public string Description { get; set; }

	}
}

