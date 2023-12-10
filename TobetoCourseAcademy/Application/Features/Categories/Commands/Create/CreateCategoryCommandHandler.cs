using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create //İşlemlerin yapıldığı alan
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {

        ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new Category()
            {
                Name = request.Name,
                Description = request.Description
            };

            await _categoryRepository.AddAsync(category);

            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse()
            {
                Name = category.Name,
                Description = category.Description,
                CreatedDate = category.CreatedDate
            };

            return createdCategoryResponse;
            

        }
    }
}

