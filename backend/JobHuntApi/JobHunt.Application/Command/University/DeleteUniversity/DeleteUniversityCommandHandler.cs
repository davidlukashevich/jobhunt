using System.Net;
using JobHunt.Application.Response;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.DeleteUniversity;

public class DeleteUniversityCommandHandler : IRequestHandler<DeleteUniversityCommand, BaseResponse>
{
    
    private readonly IUniversityRepository _universityRepository;

    public DeleteUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task<BaseResponse> Handle(DeleteUniversityCommand request, CancellationToken cancellationToken)
    {
        await _universityRepository.DeleteUniversityAsync(request.UniversityId);
        
        return new BaseResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Message = "University was deleted"
        };
    }
}