using JobHunt.Application.SingInManager;
using MediatR;

namespace JobHunt.Application.Query.User.UserSignOut;

public class UserSignOutQueryHandler : IRequestHandler<UserSignOutQuery, string>
{
    
    private readonly IApplicationSignInManager _signInManager;

    public UserSignOutQueryHandler(IApplicationSignInManager signInManager)
    {
        _signInManager = signInManager;
    }

    public Task<string> Handle(UserSignOutQuery request, CancellationToken cancellationToken)
    {
        _signInManager.SignOutAsync();
        return Task.FromResult("User Sign Out Successfully");
    }
}