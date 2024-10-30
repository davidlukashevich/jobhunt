using System.Net;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.UpdateUniversity;

public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand,BaseResponse>
{
    private readonly IUniversityRepository _universityRepository;

    public UpdateUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task<BaseResponse> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
    {
        var updateUniversityRequest = request.UpdateUniversityRequest;
        
        var updatedUniversity = UniversityMapper.ToUniversityModelUpdate(updateUniversityRequest);

        if (!await _universityRepository.UpdateUniversityAsync( updatedUniversity, request.UniversityId))
        {
            return new BaseResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "Error while updating university",
            };
        }
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "University was updated",
        };
    }
}