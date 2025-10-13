using AutoMapper;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Doctors.CreateDoctor
{
    internal sealed class CreateDoctorCommandHandler(
        IDoctorRepository doctorRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper) : IRequestHandler<CreateDoctorCommand, Result<string>>
    {
        public async  Task<Result<string>> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            Doctor doctor = mapper.Map<Doctor>(request);
            //    new()
            //{
            //    FirstName = request.FirstName,
            //    LastName = request.LastName,
            //    Department = DepartmentEnum.FromValue(request.Department)
            //};
            //doctor newleme için ayrıyeten automapper kütüphanesi kullanılabilir!

            await doctorRepository.AddAsync(doctor,cancellationToken);
           await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Doktor create is successfull!";
        }
    }
}
