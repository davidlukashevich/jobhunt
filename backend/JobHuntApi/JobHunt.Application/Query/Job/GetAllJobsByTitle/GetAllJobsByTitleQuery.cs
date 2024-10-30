using JobHunt.Application.Response.Job;
using MediatR;


namespace JobHunt.Application.Query.Job.GetAllJobsByTitle
{
    public record GetAllJobsByTitleQuery(string Title) : IRequest<List<JobsResponse>>;
    
}
