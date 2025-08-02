using eAppointmentServer.Application.Features.Auth.Login;
using eAppointmentServer.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebApi.Controllers
{
   
    public sealed  class AuthController: ApiController
        

    {
        public AuthController(IMediator mediator) : base(mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand command,CancellationToken cancellation)
        {
            var response = await _mediator.Send(command);
            return StatusCode(response.StatusCode, response);
            
        }   

    }
}
