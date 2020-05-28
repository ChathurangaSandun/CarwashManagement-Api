using CliveKumara.CarwashManagement.Api.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAsync(); 
    }
}
