using JobHunt.Application.DTO;
using JobHunt.Application.Response.Job;

namespace JobHunt.Application.Mapper.Job;

public static class JobMapper
{
    public static List<JobsResponse>  ToJobsResponse(this List<Domain.Models.Job> jobs){
    {
        var jobsResponse = jobs 
            .Select(j => new JobsResponse()
            {
                    Id = j.Id,
                    Title = j.Title,
                    CompanyName = j.CompanyName,
                    City = j.Address!.City,
                    OperationMode = j.OperationMode,
            })
            .ToList();
        
        return jobsResponse;
    }}

    public static SingleJobResponse ToSingleJobResponse(this Domain.Models.Job job)
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
}