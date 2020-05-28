using AutoMapper;
using CliveKumara.CarwashManagement.Api.Models.DatabaseModel;
using CliveKumara.CarwashManagement.Api.Models.Dtos;
using CliveKumara.CarwashManagement.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly CarWashManagementDbContext _dbContext;
        private readonly IMapper _mapper;
        public CategoryService(CarWashManagementDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetAsync()=>
            _mapper.Map<List<CategoryDto>>(await _dbContext.Categories.Select(o => o).ToListAsync());
    }
}
