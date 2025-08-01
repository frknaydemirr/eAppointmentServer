﻿using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repository;
using eAppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories
{
    internal sealed class DoctorRepository : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
