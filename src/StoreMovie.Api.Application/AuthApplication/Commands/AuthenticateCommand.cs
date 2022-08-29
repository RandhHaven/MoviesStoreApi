using System.ComponentModel.DataAnnotations;
using MediatR;

namespace StoreMovie.Api.Application.AuthApplication.Commands;
public class AuthenticateCommand : IRequest<String>
{
    [Required(AllowEmptyStrings = false)]
    public  string UserName { get; set; }
    [Required(AllowEmptyStrings = false)]
    public string Password { get; set; }
    [Required]
    public string ClientId { get; set; }
    [Required(AllowEmptyStrings = false)]
    public string GrantType { get; set; }
    public bool IsAuthenticated { get; set; }
}