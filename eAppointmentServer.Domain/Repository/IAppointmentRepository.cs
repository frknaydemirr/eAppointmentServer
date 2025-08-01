using eAppointmentServer.Domain.Entities;
using GenericRepository;

namespace eAppointmentServer.Domain.Repository
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
    }
}
