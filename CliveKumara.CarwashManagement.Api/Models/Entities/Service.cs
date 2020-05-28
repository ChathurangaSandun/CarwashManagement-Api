using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class Service: Entity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
