namespace StoreMovie.Api.Application.Common.Interfaces;

using StoreMovie.Api.Application.Common.Models;
using StoreMovie.Api.Domain.Common;

public interface IIdentityService
{
    Task<string> GetUserNameAsync(string userId);

    Task<bool> IsInRoleAsync(string userId, string role);

    Task<bool> AuthorizeAsync(string userId, string policyName);

    Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

    Task<Result> DeleteUserAsync(string userId);

    Task<UserResult> AuthenticateAsync(string email, string password);
}