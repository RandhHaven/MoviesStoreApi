namespace StoreMovie.Api.WebUI.Areas.Users.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreMovie.Api.Application.Common.Models;
using StoreMovie.Api.Application.UserApplication.Commands.CreateUser;
using StoreMovie.Api.Application.UserApplication.Commands.GetUser;
using StoreMovie.Api.WebUI.SharedController;

[ApiController]
[Area("Users")]
public class UsersUIController : ApiControllerBase
{
    [AllowAnonymous]
    [HttpPost("Signin")]
    public async Task<ActionResult<string>> GetUser(GetUserCommand command)
    {
        return await Mediator.Send(command);
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<ActionResult<Result>> Create(CreateUserCommand command)
    {
        return await Mediator.Send(command);
    }
}