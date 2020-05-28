using CliveKumara.CarwashManagement.Api.Models.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class Shop: Entity
    {
        public Shop()
        {
            Rate = 0;
            NumOfRate = 0;
            ShopServices = new HashSet<ShopService>();
            ShopImages = new HashSet<ShopImage>();
        }

        [Required]
        public string Title { get; set; }
        public string  SubTitle { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]        
        public double Rate { get; set; }
        [Required]
        public int NumOfRate { get; set; }
        public string RateText { get; set; }
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        [Required]
        public string Mobile { get; set; }        
        public string Email { get; set; }
        public string Website { get; set; }
        [Required]
        public string Hour { get; set; }
        [Required]
        public string Description { get; set; }
        public double PriceRangeStart{ get; set; }
        public double PriceRangeStop { get; set; }
        [Required]
        public string TabSettings { get; set; }
        [Required]
        public string Hours { get; set; }

        [ForeignKey("Category")]
        public long CategoryId{ get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Location")]
        public long LocationId { get; set; }
        public virtual Location Location { get; set; }

        [ForeignKey("ShopOwner")]
        public long ShopOwnerId { get; set; }
        public virtual ShopOwner ShopOwner{ get; set; }

        public virtual ICollection<ShopService> ShopServices { get; set; }
        public virtual ICollection<ShopImage> ShopImages{ get; set; }

    }
}
