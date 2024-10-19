﻿using JobHunt.Application.Mapper.Job;
using JobHunt.Application.Query.Job.GetJobById;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Interface.Repository;
using JobHunt.Domain.Models;
using MediatR;

namespace JobHunt.Application.Query.Job.GetJobById;

public class GetJobByIdQueryHandler : IRequestHandler<GetJobByIdQuery, SingleJobResponse>
{
    private readonly IJobRepository _jobRepository;

    public GetJobByIdQueryHandler(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<SingleJobResponse> Handle(GetJobByIdQuery query, CancellationToken cancellationToken)
    {
        var jobById =  await _jobRepository.GetJobByIdAsync(query.JobId);

        
        
        return jobById.ToSingleJobResponse();
    }
}