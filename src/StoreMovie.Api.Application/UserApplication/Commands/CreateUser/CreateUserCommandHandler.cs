using MediatR;
using StoreMovie.Api.Application.Common.Interfaces;
using StoreMovie.Api.Application.Common.Models;

namespace StoreMovie.Api.Application.UserApplication.Commands.CreateUser;

internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result>
{
    private readonly IIdentityService identityService;

    public CreateUserCommandHandler(IIdentityService _identityService)
    {
        this.identityService = _identityService ?? throw new ArgumentNullException(nameof(_identityService));
    }

    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await this.identityService.CreateUserAsync(request.Email, request.Password);

        return user.Result;
    }
}