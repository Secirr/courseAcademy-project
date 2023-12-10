using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Categories.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommand createCategoryCommand) //json türünde clientten gelen veriyi FromBody ile createCategoryCommand tipine çevirdim.
        {
            CreatedCategoryResponse createdCategoryResponse = await _mediator.Send(createCategoryCommand); //mediator ile createCategoryCommand'ı çağırarak aslında createdCategoryResponse'a erişmiş oluruz.

            return Ok(createdCategoryResponse);
        }

        

    }
}

