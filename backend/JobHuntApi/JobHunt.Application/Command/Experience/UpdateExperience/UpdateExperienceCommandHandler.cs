using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.UpdateExperience;

public class UpdateExperienceCommandHandler : IRequestHandler<UpdateExperienceCommand>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public UpdateExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
    {
        var updatedExperience = new Domain.Models.Experience()
        {
            Position = request.UpdateExperienceRequest.Position,
            CompanyName = request.UpdateExperienceRequest.CompanyName,
            Location = request.UpdateExperienceRequest.Location,
            Responsibility = request.UpdateExperienceRequest.Responsibility,
            WorkFrom = request.UpdateExperienceRequest.WorkFrom,
            WorkTo = request.UpdateExperienceRequest.WorkTo,
        };
        
        await _experienceRepository.UpdateExperienceAsync(updatedExperience, request.ExperienceId);
    }
}