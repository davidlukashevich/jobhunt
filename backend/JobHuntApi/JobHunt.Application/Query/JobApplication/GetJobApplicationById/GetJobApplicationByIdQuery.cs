using JobHunt.Application.Response.JobApplication;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetJobApplicationById;

public record GetJobApplicationByIdQuery(Guid Id) : IRequest<JobApplicationByIdResponse>;