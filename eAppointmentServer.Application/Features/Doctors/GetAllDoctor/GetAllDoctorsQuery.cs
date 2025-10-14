using eAppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.GetAllDoctor
{
    public sealed record class GetAllDoctorsQuery() : IRequest<Result<List<Doctor>>>
    {
    }
}
