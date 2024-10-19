using JobHunt.Application.Response.Job;
using MediatR;

namespace JobHunt.Application.Query.Job.GetAllJobsByFilter;

public record GetAllJobsByFilterQuery(string? Type, string? Technology, string? Level) : IRequest<List<JobsResponse>>;