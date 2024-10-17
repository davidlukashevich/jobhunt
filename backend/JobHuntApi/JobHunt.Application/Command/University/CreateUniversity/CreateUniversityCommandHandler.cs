using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.CreateUniversity;

public class CreateUniversityCommandHandler : IRequestHandler<CreateUniversityCommand>
{
    
    private readonly IUniversityRepository _universityRepository;

    public CreateUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
    {

        var university = new Domain.Models.University()
        {
            Id = Guid.NewGuid(),
            UniversityName = request.CreateUniversityRequest.UniversityName,
            EducationLevel = request.CreateUniversityRequest.EducationLevel,
            FieldOfStudy = request.CreateUniversityRequest.FieldOfStudy,
            Specialization = request.CreateUniversityRequest.Specialization,
            StudyFrom = request.CreateUniversityRequest.StudyFrom,
            StudyTo = request.CreateUniversityRequest.StudyTo,
        };
        
        await _universityRepository.CreateUniversityAsync(university);
    }
}