using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebApi.Abstractions
{

    //base class ->  tek tek api controller'lar için yazmak yerine

    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class ApiController :ControllerBase
    {

        public readonly IMediator _mediator;

        protected ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
