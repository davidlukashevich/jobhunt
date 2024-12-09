using JobHunt.Application.Request.JobApplication;
using JobHunt.Application.Response.JobApplication;
using JobHunt.Domain.Enums;
using JobHunt.Domain.Models;

namespace JobHunt.Application.Mapper;

public static class JobApplicationMapper
{
    public static JobApplication ToJobApplicationModelCreate(CreateJobApplicationRequest request, Guid fileGuid)
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
            CreatedBy = request.CreatedBy,
            Status = JobApplicationStatus.Pending.ToString(),
            Cv = $"https://jobhuntstorage.blob.core.windows.net/files/cv_{fileGuid}_{request.Cv.FileName}"
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
            CreatedAt = jobApplication.CreatedAt
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
                CreatedAt = j.CreatedAt,
                
            })
            .ToList();
        
        return jobApplicationsByJobIdResponse;
    }

    public static List<ProfileJobApplicationsResponse> ToProfileJobApplicationsResponse(
        this List<JobApplication>? jobApplications)
    {
        var profileJobApplicationsResponse = jobApplications
            .Select(j => new ProfileJobApplicationsResponse()
            {
                Id = j!.Id,
                JobTitle = j.Job!.Title,
                JobCompanyName = j.Job!.CompanyName,
                JobCompanyLogo = j.Job.Image!.ImageUrl,
                JobAddressCountry = j.Job.Address!.Country,
                JobAddressCity = j.Job.Address!.City,
                Status = j.Status,
                CreatedAt = j.CreatedAt,
                JobId = j.JobId,
            })
            .ToList();
        
        return profileJobApplicationsResponse;
    }
}
