using Microsoft.AspNetCore.Mvc;
using StoreMovie.Api.Application.AuthApplication.Commands;
using StoreMovie.Api.WebUI.SharedController;

namespace StoreMovie.Api.WebUI.Areas.Auth.Controllers;

public class AuthController : ApiControllerBase
{
    [HttpPost]
    [Route("~/get/token")]
    [Consumes("application/x-www-form-urlencoded")]
    [ProducesResponseType(typeof(String), 200)]
    public async Task<ActionResult<String>> Authenticate([FromForm] AuthenticateCommand user)
    {
        try
        {
            return await this.Mediator.Send(user);
        }
        catch (Exception ex)
        {
            return Unauthorized(ex.Message);
        }
    }
}