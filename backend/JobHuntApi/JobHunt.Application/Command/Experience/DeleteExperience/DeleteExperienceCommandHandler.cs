using System.Net;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.DeleteExperience;

public class DeleteExperienceCommandHandler : IRequestHandler<DeleteExperienceCommand, BaseResponse>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public DeleteExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task<BaseResponse> Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
    {
        await _experienceRepository.DeleteExperienceAsync(request.ExperienceId);
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Experience was deleted",
        };
    }
}