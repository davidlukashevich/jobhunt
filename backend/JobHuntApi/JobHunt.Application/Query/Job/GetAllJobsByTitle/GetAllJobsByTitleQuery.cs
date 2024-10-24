using JobHunt.Application.Response.Job;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt.Application.Query.Job.GetAllJobsByTitle
{
    public record GetAllJobsByTitleQuery(string Title) : IRequest<List<JobsResponse>>;
    
}
