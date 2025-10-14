using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Appointments.UpdateAppointment
{
    public sealed record  class UpdateAppointmentCommand(
        Guid Id,
        string StartDate,
        string EndDate) : IRequest<Result<string>>;
}
