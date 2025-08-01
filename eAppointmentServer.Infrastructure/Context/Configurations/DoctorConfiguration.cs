using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Context.Configurations
{
    internal sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).HasColumnType("varchar(50)");
            //builder.HasIndex(x => new {x.FirstName,x.LastName} ).IsUnique();
        }
    }

}


