using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class Category: Entity
    {

        public Category()
        {
        }

        [Required]
        public string Name{ get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Icon { get; set; }

        public virtual ICollection<Shop> Shops { get; set; }
    }
}
