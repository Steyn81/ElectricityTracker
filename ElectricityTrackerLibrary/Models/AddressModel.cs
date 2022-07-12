using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityTrackerLibrary.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string FlatUnit { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
    }
}
