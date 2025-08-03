using eAppointmentServer.Application.Features.Doctors.GetAllDoctor;
using eAppointmentServer.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebApi.Controllers
{
    public class DoctorsController : ApiController
    {
        public DoctorsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllDoctorQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
    }
}
