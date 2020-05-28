using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class ShopImage: Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Path { get; set; }

        [ForeignKey("Shop")]
        public long ShopId { get; set; }
        public virtual Shop Shop { get; set; }

    }
}
