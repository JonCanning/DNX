using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using CTM.Postcode.Service.models;

namespace CTM.Postcode.Service.Controllers
{
    public class AddressController : Controller
    {
        [HttpGet]
        [Route("addresses/{postcode}/{number}")]
        public List<Address> Get(string postcode, string number)
        {
            var addresses = new List<Address>();
            
            var address = new Address
            {
                FormattedAddress = new FormattedAddress
                {
                    LineOne = "1 Brudenell",
                    LineTwo = "Orton Goldhay",
                    LineThree = "Peterborough",
                    LineFour = "",
                    LineFive = "",
                    LineSix = "",
                    LineSeven = "",
                    LineEight = "PE2 5SX"
                },
                PostOfficeAddress = new PostOfficeAddress
                {
                    OrganisationName = "",
                    Department = "",
                    SubBuilding = "",
                    Building = "",
                    Number = "1",
                    DependentThoroughfare = "",
                    Thoroughfare = "Brudenell",
                    DoubleDependentLocality = "",
                    DependentLocality = "Orton Goldhay",
                    Town = "Peterborough",
                    PostalCounty = "",
                    Postcode = "PE2 5SX",
                    AbbreviatedPostalCounty = "",
                    OptionalCounty = "Cambridgeshire",
                    AbbreviatedOptionalCounty = "Cambs",
                    TraditionalCounty = "Huntingdonshire",
                    AdministrativeCounty = "Peterborough",
                    DPS = "1A",
                    POBox = null
                }
            };
            addresses.Add(address);
            return addresses;
        }
    }
}
