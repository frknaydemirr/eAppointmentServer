using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Configurations
{
    internal sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).HasColumnType("varchar(50)");
            //builder.HasIndex(x => new {x.FirstName,x.LastName} ).IsUnique();

            builder.Property(p => p.Department).HasConversion
                (v => v.Value, v => DepartmentEnum.FromValue(v)).
                HasColumnName("Department");
            //database de kayıt yaparken neyi kaydedeceğimizi verdik enumu!
            //class -> database e maplenecek

        }
    }

}


