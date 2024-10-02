using SeminarPoslednii.Models;
using SeminarPoslednii.ViewModels;

namespace SeminarPoslednii.Abstractions
{
    public interface IUserRepository
    {
        string AddUser(UserDto userDto);
        
        string CheckUser(LoginDto loginDto);
        
    }
}
