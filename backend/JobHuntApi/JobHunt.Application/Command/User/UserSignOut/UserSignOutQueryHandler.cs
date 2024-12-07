using JobHunt.Application.SingInManager;
using MediatR;

namespace JobHunt.Application.Command.User.UserSignOut;

public class UserSignOutQueryHandler : IRequestHandler<UserSignOutCommand, string>
{
    
    private readonly IApplicationSignInManager _signInManager;

    public UserSignOutQueryHandler(IApplicationSignInManager signInManager)
    {
        _signInManager = signInManager;
    }

    public Task<string> Handle(UserSignOutCommand request, CancellationToken cancellationToken)
    {
        _signInManager.SignOutAsync();
        return Task.FromResult("User Sign Out Successfully");
    }
}