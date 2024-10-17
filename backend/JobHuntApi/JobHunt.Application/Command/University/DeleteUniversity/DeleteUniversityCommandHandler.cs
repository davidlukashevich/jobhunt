using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.DeleteUniversity;

public class DeleteUniversityCommandHandler : IRequestHandler<DeleteUniversityCommand>
{
    
    private readonly IUniversityRepository _universityRepository;

    public DeleteUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task Handle(DeleteUniversityCommand request, CancellationToken cancellationToken)
    {
        await _universityRepository.DeleteUniversityAsync(request.UniversityId);
    }
}