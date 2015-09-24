using Accommodation.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Accommodation.Models.Entities

{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        [NotMapped]
        public HttpPostedFileBase image { get; set; }
        public RentOrSale RentSale { get; set; }
        public AccommodationType Types { get; set; }
        

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Rent> rents { get; set; }
        //public virtual ICollection<>
    }
}