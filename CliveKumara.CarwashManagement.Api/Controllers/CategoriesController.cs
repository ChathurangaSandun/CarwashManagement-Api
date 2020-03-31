using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CliveKumara.CarwashManagement.Api.Models.DatabaseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CliveKumara.CarwashManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CarWashManagementDbContext _dbContext;

        public CategoriesController(CarWashManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


    }
}