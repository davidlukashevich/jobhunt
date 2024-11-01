using JobHunt.Application.Exceptions.Job;
using JobHunt.Application.Exceptions.JobApplication;
using JobHunt.Application.Exceptions.Profile;
using JobHunt.Application.Exceptions.User;
using JobHunt.Application.Response;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace JobHunt.Application.Exceptions;

public class GlobalException : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        
        var (status, message) = exception switch
        {
            UserDoesNotExist userDoesNotExist => (404, userDoesNotExist.Message),
            UserExistsException userExistsException => (409, userExistsException.Message),
            UserWrongCredentialsException userWrongCredentialsException => (401, userWrongCredentialsException.Message),
            ProfileNotFoundException profileNotFoundException => (404, profileNotFoundException.Message),
            JobNotFoundException jobNotFoundException => (404, jobNotFoundException.Message),
            JobApplicationNotFound jobApplicationNotFound => (404, jobApplicationNotFound.Message),
            _ => (500, "Error"),
        };

        httpContext.Response.StatusCode = status;

        var errorResponse = new ErrorResponse()
        {
            StatusCode = status,
            Message = message
        };

        await httpContext.Response.WriteAsJsonAsync(errorResponse, cancellationToken: cancellationToken);
        return true;
    }
}