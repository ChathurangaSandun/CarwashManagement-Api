using AutoMapper;
using CliveKumara.CarwashManagement.Api.Models.Dtos;
using CliveKumara.CarwashManagement.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.AutoMapperProfiles
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap(); // means you want to map from User to UserDTO
        }

    }
}
