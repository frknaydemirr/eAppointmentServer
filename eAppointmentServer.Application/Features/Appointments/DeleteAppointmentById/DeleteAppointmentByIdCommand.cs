using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Appointments.DeleteAppointmentById
{
    public sealed record  class DeleteAppointmentByIdCommand(
        Guid Id
        ) : IRequest<Result<string>>;
}
