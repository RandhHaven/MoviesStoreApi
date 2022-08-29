namespace StoreMovie.Api.Application.Common.Interfaces;

using StoreMovie.Api.Domain.Common;

public interface ITokenSignerService
{
    public string SignToken(UserResult user);
}