using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class Location : Entity
    {
        public Location()
        {
           
        }

        public string Name { get; set; }
        [Required]
        public float Lat { get; set; }
        [Required]
        public float Long { get; set; }
        public string Address { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
