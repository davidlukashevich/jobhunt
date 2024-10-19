using JobHunt.Application.Response.Profile;
using MediatR;

namespace JobHunt.Application.Query.Profile.GetProfile;

public record GetProfileQuery(Guid Id) : IRequest<ProfileResponse>;