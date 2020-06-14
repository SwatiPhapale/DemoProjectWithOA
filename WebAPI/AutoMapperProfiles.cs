using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Core.DTOs;
using TempProject.Core.Entities;

namespace TempProject.WebAPI
{
    public class AutoMapperProfiles : Profile
    {
      public  AutoMapperProfiles()
        {
            CreateMap<UserRegisterDTO, User>();
        }
    }
}
