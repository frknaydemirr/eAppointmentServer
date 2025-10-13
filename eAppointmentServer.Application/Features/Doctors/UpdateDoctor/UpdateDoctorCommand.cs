using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.UpdateDoctor
{
    public sealed record class UpdateDoctorCommand(
        Guid Id,
        string FirstName,
        string LastName,
        int DepartmentValue) : IRequest<Result<string>>;
}
