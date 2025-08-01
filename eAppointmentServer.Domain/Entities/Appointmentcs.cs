using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Domain.Entities
{
    public sealed class Appointmentcs
    {
        public Appointmentcs()
        {
            Id= Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Doctor? Doctor { get; set; }
        public Guid DoctorId { get; set; }

        public Patient? Patient { get; set; }
        public Guid PatientId { get; set; }

        public Guid StartDate { get; set; }

        public Guid EndDate { get; set; }

        public bool IsCompluted { get; set; }
    }
}
