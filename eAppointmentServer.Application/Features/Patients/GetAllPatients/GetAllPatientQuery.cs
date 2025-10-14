using eAppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Patients.GetAllPatients
{
    public sealed record class GetAllPatientQuery : IRequest<Result<List<Patient>>>;
}

