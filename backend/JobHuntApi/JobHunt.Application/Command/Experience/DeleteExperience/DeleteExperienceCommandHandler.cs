using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.DeleteExperience;

public class DeleteExperienceCommandHandler : IRequestHandler<DeleteExperienceCommand>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public DeleteExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
    {
        await _experienceRepository.DeleteExperienceAsync(request.ExperienceId);
    }
}