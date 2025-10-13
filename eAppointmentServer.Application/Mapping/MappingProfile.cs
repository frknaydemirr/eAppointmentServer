using AutoMapper;
using eAppointmentServer.Application.Features.Doctors.CreateDoctor;
using eAppointmentServer.Application.Features.Doctors.UpdateDoctor;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateDoctorCommand, Doctor>().ForMember(member=>member.Department,options
                =>options.MapFrom(map=>DepartmentEnum.FromValue(map.DepartmentValue)));

            CreateMap<UpdateDoctorCommand, Doctor>().ForMember(member => member.Department, options
               => options.MapFrom(map => DepartmentEnum.FromValue(map.DepartmentValue)));
        }
    }
}
