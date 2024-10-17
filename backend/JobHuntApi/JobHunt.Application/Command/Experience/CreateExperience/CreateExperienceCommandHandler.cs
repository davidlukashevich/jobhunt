using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.CreateExperience;

public class CreateExperienceCommandHandler : IRequestHandler<CreateExperienceCommand>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public CreateExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
    {
        var experience = new Domain.Models.Experience()
        {
            Id = Guid.NewGuid(),
            Position = request.CreateExperienceRequest.Position,
            Location = request.CreateExperienceRequest.Location,
            CompanyName = request.CreateExperienceRequest.CompanyName,
            Responsibility = request.CreateExperienceRequest.Responsibility,
            WorkFrom = request.CreateExperienceRequest.WorkFrom,
            WorkTo = request.CreateExperienceRequest.WorkTo,
        };
        
        await _experienceRepository.CreateExperienceAsync(experience);
    }
}