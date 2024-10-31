using JobHunt.Application.Response.JobApplication;
using MediatR;

namespace JobHunt.Application.Query.JobApplication.GetAllJobApplicationsByCreatedById;

public record GetAllJobApplicationsByCreatedByIdQuery(string CreatedById) : IRequest<List<ProfileJobApplicationsResponse>>;