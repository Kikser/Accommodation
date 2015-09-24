using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accommodation.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int Price { get; set; }
        public int RentTime { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Accomodation Accomodations { get; set; }
    }
}