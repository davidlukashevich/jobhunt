using JobHunt.Application.Request.Job;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public record CreateJobCommand(CreateJobRequest CreateJobRequest) : IRequest<BaseResponse>;