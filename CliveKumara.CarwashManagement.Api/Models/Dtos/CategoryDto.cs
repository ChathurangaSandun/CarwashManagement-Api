using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Dtos
{
    public class CategoryDto: Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public int Count { get; set; }
    }
}
