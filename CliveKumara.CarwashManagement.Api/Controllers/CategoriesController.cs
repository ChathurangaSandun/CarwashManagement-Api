using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CliveKumara.CarwashManagement.Api.Models.DatabaseModel;
using CliveKumara.CarwashManagement.Api.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CliveKumara.CarwashManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CarWashManagementDbContext _dbContext;
        private readonly IMapper mapper;

        public CategoriesController(CarWashManagementDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<List<CategoryDto>> Get() => 
            this.mapper.Map<List<CategoryDto>>(await this._dbContext.Categories.Select(o => o).ToListAsync());
    }
}