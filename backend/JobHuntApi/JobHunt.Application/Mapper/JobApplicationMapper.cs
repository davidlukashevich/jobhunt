using JobHunt.Application.Request;
using JobHunt.Application.Response.JobApplication;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class JobApplicationMapper
{
    public static JobApplication ToJobApplicationModelCreate(CreateJobApplicationRequest request)
    {
        return new JobApplication()
        {
            Id = Guid.NewGuid(),
            Name = request.Firstname,
            LastName = request.Lastname,
            Email = request.Email,
            Phone = request.Mobile,
            AboutInformation = request.AboutUser,
            JobId = request.JobId,
        };
    }

    public static JobApplicationByIdResponse ToJobApplicationByIdResponse(this JobApplication? jobApplication)
    {
        return new JobApplicationByIdResponse()
        {
            Id = jobApplication!.Id,
            Name = jobApplication.Name,
            Lastname = jobApplication.LastName,
            Email = jobApplication.Email,
            Phone = jobApplication.Phone,
            AboutInformation = jobApplication.AboutInformation,
            Cv = jobApplication.Cv,
        };
    }

    public static List<JobApplicationsByJobIdResponse> ToJobApplicationsByJobIdResponse(
        this List<JobApplication? > jobApplication)
    {
        var jobApplicationsByJobIdResponse = jobApplication
            .Select(j => new JobApplicationsByJobIdResponse()
            {
                Id = j!.Id,
                Name = j.Name,
                Lastname = j.LastName,
                Email = j.Email,
                Phone = j.Phone,
            })
            .ToList();
        
        return jobApplicationsByJobIdResponse;
    }
}