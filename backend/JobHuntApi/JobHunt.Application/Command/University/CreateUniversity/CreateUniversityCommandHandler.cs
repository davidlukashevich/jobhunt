using System.Net;
using JobHunt.Application.Mapper;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.CreateUniversity;

public class CreateUniversityCommandHandler : IRequestHandler<CreateUniversityCommand, BaseResponse>
{
    
    private readonly IUniversityRepository _universityRepository;

    public CreateUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task<BaseResponse> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
    {
        var createUniversityRequest = request.CreateUniversityRequest;
        
        
        var university = UniversityMapper.ToUniversityModelCreate(createUniversityRequest, request.ProfileId);
       
        
        await _universityRepository.CreateUniversityAsync(university);
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "University was created",
        };
    }
}