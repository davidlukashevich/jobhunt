using System.Net;
using JobHunt.Application.Response;
using JobHunt.Domain.Enums;
using JobHunt.Domain.Interface.Repository;
using MediatR;

namespace JobHunt.Application.Command.JobApplication.UpdateJobApplicationStatus;

public class UpdateJobApplicationStatusCommandHandler : IRequestHandler<UpdateJobApplicationStatusCommand, BaseResponse>
{
    private readonly IJobApplicationRepository _jobApplicationRepository;

    public UpdateJobApplicationStatusCommandHandler(IJobApplicationRepository jobApplicationRepository)
    {
        _jobApplicationRepository = jobApplicationRepository;
    }

    public async Task<BaseResponse> Handle(UpdateJobApplicationStatusCommand request, CancellationToken cancellationToken)
    {
        
        
        switch (request.Status)
        {
            case "Accepted":
                await _jobApplicationRepository.UpdateJobApplicationStatusAsync(
                    request.JobApplicationId,
                    JobApplicationStatus.Accepted.ToString()
                    );
                break;
            
            case "Rejected":
                await _jobApplicationRepository.UpdateJobApplicationStatusAsync(
                    request.JobApplicationId,
                    JobApplicationStatus.Rejected.ToString()
                    );
                break;
            
            default:
                throw new Exception("Unknown status");
        }


        
        
        return new BaseResponse
        {
            StatusCode = HttpStatusCode.OK,
            Message = "Job application status was updated successfully!"
        };
        
    }
}