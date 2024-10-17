using JobHunt.Application.Request;
using MediatR;

namespace JobHunt.Application.Command.Job.CreateJob;

public record CreateJobCommand(CreateJobRequest CreateJobRequest) : IRequest;