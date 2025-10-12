using eAppointmentServer.Application.Features.Doctors.GetAllDoctor;
using eAppointmentServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebAPI.Controllers
{
    public class DoctorsControllers : ApiController
    {
        public DoctorsControllers(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult>  GetAll(GetAllDoctorQuery request,CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
