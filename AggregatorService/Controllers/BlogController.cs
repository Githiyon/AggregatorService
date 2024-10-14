using AggregatorService.Application.Features.Blogs.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorService.Controllers
{
    [Route("api/aggregator-sq/[controller]")]
    [ApiController]
    public class BlogController (IMediator mediator):ApiControllerBase(mediator)
    {
        [HttpPost]
        public async Task<IActionResult> Get(GetBlogsQuery getblogsQuery)
        {
            var result=await Mediator.Send(getblogsQuery);
            return RefineResult(result);
        }
    }
}
