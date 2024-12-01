using MediatR;

namespace JobHunt.Application.Query.User.UserSignOut;

public record UserSignOutQuery() : IRequest<string>;