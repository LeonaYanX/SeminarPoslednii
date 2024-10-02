using SeminarPoslednii.ViewModels;
using System.Security.Cryptography;

namespace SeminarPoslednii.Abstractions
{
    public interface ITokenRepository
    {
        string GenerateToken(UserDto userDto);

        bool ValidateToken(string token);

    }
}
