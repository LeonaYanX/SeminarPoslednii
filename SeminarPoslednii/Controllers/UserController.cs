using Microsoft.AspNetCore.Mvc;
using SeminarPoslednii.Abstractions;
using SeminarPoslednii.Models;
using SeminarPoslednii.Repository;
using SeminarPoslednii.ViewModels;

namespace SeminarPoslednii.Controllers
{
    [ApiController]
    [Route("controller")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
       


        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
            
        } 

        [HttpPost(template: "AddUser")]
        public ActionResult<string> AddUser(UserDto userDto) 
        {
            try 
            {
            return Ok(_userRepository.AddUser(userDto));
            } 
            catch 
            {
            return StatusCode(500);
            }
        }

        [HttpPost(template: "Login")]
        public ActionResult<string> Login(LoginDto loginDto)
        {
            try 
            {
                
              return Ok(_userRepository.CheckUser(loginDto));

            }
            catch 
            {
                return StatusCode(500);
            }
        }


    }
}
