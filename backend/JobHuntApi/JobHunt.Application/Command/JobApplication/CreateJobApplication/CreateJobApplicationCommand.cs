using JobHunt.Application.Request.JobApplication;
using JobHunt.Application.Response;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.CreateJobApplication;

public record CreateJobApplicationCommand(CreateJobApplicationRequest CreateJobApplicationRequest) : IRequest<BaseResponse>;
