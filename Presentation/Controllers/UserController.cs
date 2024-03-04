using Application.Interfaces;
using Domain.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost(Name = "CreateUser")]
        public async Task<UserModel> Create(UserModel model)
        {
            var res = await _userService.Create(model);
            return res;
        }
    }
}
