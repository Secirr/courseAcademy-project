using System;
using MediatR;

namespace Application.Features.Categories.Commands.Update
{
	public class UpdateCategoryCommand : IRequest<UpdatedCategoryResponse>
	{
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

