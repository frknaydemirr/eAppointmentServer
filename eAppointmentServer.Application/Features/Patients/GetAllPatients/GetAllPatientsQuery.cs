using eAppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Patients.GetAllPatients
{
    public sealed record class GetAllPatientsQuery : IRequest<Result<List<Patient>>>;
}

