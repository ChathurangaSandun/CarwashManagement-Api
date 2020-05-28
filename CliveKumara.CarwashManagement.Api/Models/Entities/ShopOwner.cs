using CliveKumara.CarwashManagement.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class ShopOwner : Entity
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Photo { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public double Rate { get; set; }

        public  virtual Shop Shop { get; set; }
    }
}
