using MediatR;

namespace StoreMovie.Api.Application.AuthApplication.Commands;

public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, String>
{
    public Task<String> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}