using MediatR;

namespace StoreMovie.Api.Application.UserApplication.Commands.GetUser;

public sealed class GetUserCommand : IRequest<String>
{
    public String Email { get; set; }
    public String Password { get; set; }
}