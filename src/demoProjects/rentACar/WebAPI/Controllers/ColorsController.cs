using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Colors.Commands.CreateColor;
using Application.Features.Colors.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateColorCommand createColorCommand)
        {
            CreatedColorDto result = await Mediator.Send(createColorCommand);
            return Created("", result);
        }
    }
}
