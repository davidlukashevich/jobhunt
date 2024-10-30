using System.Net;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.Experience.UpdateExperience;

public class UpdateExperienceCommandHandler : IRequestHandler<UpdateExperienceCommand, BaseResponse>
{
    
    private readonly IExperienceRepository _experienceRepository;

    public UpdateExperienceCommandHandler(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task<BaseResponse> Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
    {

        var updateExperienceRequest = request.UpdateExperienceRequest;
        
        var updatedExperience = ExperienceMapper.ToExperienceModelUpdate(updateExperienceRequest);

        if (!await _experienceRepository.UpdateExperienceAsync(updatedExperience, request.ExperienceId))
        {
            return new BaseResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Failed to update experience",
            };
        }
        
      
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Experience was updated",
        };
    }
}