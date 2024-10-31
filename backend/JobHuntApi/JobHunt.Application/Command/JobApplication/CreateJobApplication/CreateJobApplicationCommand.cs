using JobHunt.Application.Request;
using JobHunt.Application.Response;
using JobHunt.Domain.Models;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.CreateJobApplication;

public record CreateJobApplicationCommand(CreateJobApplicationRequest CreateJobApplicationRequest) : IRequest<BaseResponse>;
