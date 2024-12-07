using MediatR;

namespace JobHunt.Application.Command.User.UserSignOut;

public record UserSignOutCommand() : IRequest<string>;