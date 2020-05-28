using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Models.Entities
{
    public class ShopService
    {
        [Key]
        [Column(Order = 0)]
        public long ShopId { get; set; }
        public virtual Shop Shop { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ServiceId { get; set; }
        public virtual Service Service { get; set; }
        
        public double Price { get; set; }
    }
}
