using NewClick.API.Models;

namespace NewClick.API.Services.Interfaces;

public interface IJwtService
{
    string GenerateToken(Usuario user);
}
