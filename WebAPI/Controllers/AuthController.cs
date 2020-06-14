using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TempProject.Core.DTOs;
using TempProject.Core.Entities;

namespace TempProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private UserManager<User> _userManager;
        //private SignInManager<User> _signInManager;

        public AuthController(IConfiguration config, IMapper mapper,UserManager<User> userManager)
        {
            _config = config;
            _mapper = mapper;
            _userManager = userManager;
            //_signInManager = signInManager;
            _config = config;
            _mapper = mapper;
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var userToCreate = _mapper.Map<UserRegisterDTO,User>(userRegisterDTO);
            var result = await _userManager.CreateAsync(userToCreate,
            userRegisterDTO.Password);
            var userToReturn = _mapper.Map<UserDetailsDto>(userToCreate);
            if (result.Succeeded)
            {
                return CreatedAtRoute("GetUser", new
                {
                    controller = "Users",
                    id = userToCreate.Id
                }, userToReturn);
            }
            return BadRequest(result.Errors);
        }
    }
}
