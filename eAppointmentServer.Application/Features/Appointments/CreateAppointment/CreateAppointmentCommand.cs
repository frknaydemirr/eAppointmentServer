using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Appointments.CreateAppointment
{
    public sealed record class CreateAppointmentCommand(
        string startDate,
        string endDate,
        Guid DoctorId,
        Guid? PatientId,
        string FirstName,
        string LastName,
        string IdentityNumber,
        string Town,
        string City,
        string FullAddress
        ) : IRequest<Result<string>>;
    }

