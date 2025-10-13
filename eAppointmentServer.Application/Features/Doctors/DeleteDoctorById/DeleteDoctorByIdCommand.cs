using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.DeleteDoctorById
{
    public sealed record class DeleteDoctorByIdCommand(
        Guid Id):IRequest<Result<string>>;
}
