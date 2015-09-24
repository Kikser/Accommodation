using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Accommodation.Models.Entities;

namespace Accommodation.ViewModels
{
    public class AccomodationsViewModel
    {
        public bool LoggedUser { get; set; }
        public Accomodation Accomodation { get; set; }
        public List<Accomodation> Accomodations { get; set; }
    }
}