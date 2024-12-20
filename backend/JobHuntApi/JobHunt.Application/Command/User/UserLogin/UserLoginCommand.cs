﻿using JobHunt.Application.Request.User;
using JobHunt.Application.Response.User;
using MediatR;

namespace JobHunt.Application.Command.User.UserLogin;

public record UserLoginCommand(UserLoginRequest UserLoginRequest) : IRequest<UserLoginResponse>;
