using Application.Features.Categories.Commands.Create;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeletedCategoryResponse>
    {

        ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {

            _categoryRepository = categoryRepository;

        }

        public async Task<DeletedCategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            Category categoryDelete = new Category()
            {
                Name = request.Name,
                Description = request.Description
            };

            await _categoryRepository.DeleteAsync(categoryDelete);

            DeletedCategoryResponse deletedCategoryResponse = new DeletedCategoryResponse()
            {
                Name = categoryDelete.Name,
                Description = categoryDelete.Description,
                DeletedDate = DateTime.UtcNow
            };

            return deletedCategoryResponse;


        }
    }
}

