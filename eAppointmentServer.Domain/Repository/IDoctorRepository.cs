using eAppointmentServer.Domain.Entities;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Repository
{
    public interface IDoctorRepository :IRepository<Doctor>    
    {
    }
}
