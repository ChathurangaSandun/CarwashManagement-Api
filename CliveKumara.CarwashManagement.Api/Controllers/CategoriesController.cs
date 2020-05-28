using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CliveKumara.CarwashManagement.Api.Models.Common;
using CliveKumara.CarwashManagement.Api.Models.DatabaseModel;
using CliveKumara.CarwashManagement.Api.Models.Dtos;
using CliveKumara.CarwashManagement.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CliveKumara.CarwashManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> Get() =>
            Ok(new ResponseData<List<CategoryDto>> { Data = await _categoryService.GetAsync() });

    }


}