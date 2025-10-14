using Azure.Core;
using eAppointmentServer.Application.Features.Appointments.GetAllDoctorByDepartment;
using eAppointmentServer.Application.Features.Auth.Login;
using eAppointmentServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebAPI.Controllers
{

    public sealed  class AppointmentsController : ApiController
       
    {
        public AppointmentsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        
        public async Task<IActionResult> GetDoctorsByDepartment(GetAllDoctorByDepartmentQuery request,CancellationToken cancellationToken)
        {

            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode,response);
        }



    }
}
