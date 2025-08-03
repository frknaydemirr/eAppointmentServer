using AutoMapper;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repository;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.CreateDoctor
{
    internal sealed class CreateDoctorCommandHandler(
        IDoctorRepository doctorRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper
        )                   : IRequestHandler<CreateDoctorCommand, Result<string>>
    {
        public async  Task<Result<string>> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            //requestten gelen tüm verileir doktora aktarır!
           Doctor doctor= mapper.Map<Doctor>(request);
            await doctorRepository.AddAsync(doctor, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Doctor created successfuly";
        }
    }
    
        
    }







