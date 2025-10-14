using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Patients.DeletePatientById
{
    public sealed record class DeletePatientByIdCommand(
        Guid Id) : IRequest<Result<string>>;
}
