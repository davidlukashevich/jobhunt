using System.Net;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.CreateExperience;

public class CreateExperienceCommandHandler : IRequestHandler<CreateExperienceCommand, BaseResponse>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public CreateExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task<BaseResponse> Handle(CreateExperienceCommand request, CancellationToken cancellationToken)
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
            ProfileId = request.ProfileId
        };
        
        await _experienceRepository.CreateExperienceAsync(experience);
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Message = "Experience was created",
        };
    }
}