using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Update
{
	public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdatedCategoryResponse>
	{

		ICategoryRepository _categoryRepository;

		public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;

        }

        public async Task<UpdatedCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category categoryUpdate = new Category()
            {
                Name = request.Name,
                Description = request.Description
            };

            await _categoryRepository.UpdateAsync(categoryUpdate);

            UpdatedCategoryResponse updatedCategoryResponse = new UpdatedCategoryResponse()
            {
                Name = categoryUpdate.Name,
                Description = categoryUpdate.Description,
                UpdatedDate = DateTime.UtcNow
                
            };

            return updatedCategoryResponse;
        }
    }
}

