using eAppointmentServer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAppointmentServer.Application.Features.Appointments.GetAllDoctorByDepartment
{
    public sealed  record  class GetAllDoctorByDepartmentQuery(
        int DepartmentValue): IRequest<Result<List<Doctor>>>;
}
