using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TempProject.Core.DTOs;
using TempProject.Core.Entities;

namespace TempProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private UserManager<User> _userManager;
        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == id);

            var userToReturn = _mapper.Map<UserDetailsDto>(user);

            return Ok(userToReturn);
        }
    }
}
