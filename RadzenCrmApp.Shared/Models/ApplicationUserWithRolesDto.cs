using System.ComponentModel.DataAnnotations;

namespace RadzenCrmApp.Shared.Models;

public class ApplicationUserWithRolesDto : ApplicationUserDto
{
    public List<string>? Roles { get; set; }
}
