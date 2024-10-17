﻿using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.University.UpdateUniversity;

public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand>
{
    private readonly IUniversityRepository _universityRepository;

    public UpdateUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
    {
        var updatedUniversity = new Domain.Models.University()
        {
            UniversityName = request.UpdateUniversityRequest.UniversityName,
            EducationLevel = request.UpdateUniversityRequest.EducationLevel,
            FieldOfStudy = request.UpdateUniversityRequest.FieldOfStudy,
            StudyFrom = request.UpdateUniversityRequest.StudyFrom,
            Specialization = request.UpdateUniversityRequest.Specialization,
            StudyTo = request.UpdateUniversityRequest.StudyTo,
        };
        
        await _universityRepository.UpdateUniversityAsync( updatedUniversity, request.UniversityId);
    }
}