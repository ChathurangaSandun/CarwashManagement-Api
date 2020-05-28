using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Common
{
    public class Entity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime  UpdatedDate { get; set; }
    }
}
