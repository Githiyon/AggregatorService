using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorService.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        private IMediator mediator;
        protected IMediator Mediator=>mediator??(mediator=base.HttpContext.RequestServices.GetRequiredService<IMediator>());
        protected ApiControllerBase(IMediator mediator)
        {
            mediator = mediator;
            
        }
        protected IActionResult RefineResult<T>(T result,Func<T,bool> criteria=null,bool isUpdate=false)
        {
            if (result==null && isUpdate)
            {
                return NoContent();
            }
            if (result == null )
            {
                return NotFound();
            }
            if(criteria==null || criteria(result)) 
                { return Ok(); }
            return NotFound();
            
        }
    }
}
