using JobHunt.Application.DTO;
using JobHunt.Application.Request;
using JobHunt.Application.Response.Job;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class JobMapper
{
    public static List<JobsResponse>  ToJobsResponse(this List<Job> jobs){
    {
        var jobsResponse = jobs 
            .Select(j => new JobsResponse()
            {
                    Id = j.Id,
                    Title = j.Title,
                    CompanyName = j.CompanyName,
                    City = j.Address!.City,
                    OperationMode = j.OperationMode,
                   // CompanyLogo = j.CompanyLogo,
                    
            })
            .ToList();
        
        return jobsResponse;
    }}

    public static SingleJobResponse ToSingleJobResponse(this Job job)
    {
        var singleJobResponse = new SingleJobResponse()
        {
            Id = job.Id,
            Title = job.Title,
            CompanyName = job.CompanyName,
            OperationMode = job.OperationMode,
            ContractType = job.ContractType,
            JobLevel = job.JobLevel,
            Responsibilities = job.Responsibilities,
            Requirements = job.Requirements,
            //CompanyLogo = job.CompanyLogo,
            Address = new AddressDTO()
            {
                Id = job.Address!.Id,
                Country = job.Address.Country,
                City = job.Address.City,
                Street = job.Address.Street,
            },
        };
        
        return singleJobResponse;
    }

    public static Job ToJobModelCreate( CreateJobRequest jobRequest, Guid addressId)
    {
        return new Job()
        {
            Id = Guid.NewGuid(),
            Title = jobRequest.Title,
            CompanyName = jobRequest.CompanyName,
            OperationMode = jobRequest.OperationMode,
            ContractType = jobRequest.ContractType,
            JobLevel = jobRequest.JobLevel,
            Responsibilities = jobRequest.Responsibilities,
            Requirements = jobRequest.Requirements,
            AddressId = addressId,
            Type = jobRequest.Type,
            Technology = jobRequest.Technology,
            CreatedBy = jobRequest.CreatedBy,
        };
    }
    
    public static Job ToJobModelUpdate(UpdateJobRequest jobRequest)
    {
        return new Job()
        {
            Title = jobRequest.Title,
            CompanyName = jobRequest.CompanyName,
            OperationMode = jobRequest.OperationMode,
            ContractType = jobRequest.ContractType,
            JobLevel = jobRequest.JobLevel,
            Responsibilities = jobRequest.Responsibilities,
            Requirements = jobRequest.Requirements,
            Type = jobRequest.Type,
            Technology = jobRequest.Technology,
            CreatedBy = jobRequest.CreatedBy!,
        };
    }
}