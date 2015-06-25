namespace CTM.Postcode.Service.models
{
   public class PostOfficeAddress
    {
        public string OrganisationName { get; set; }
        public string Department { get; set; }
        public string SubBuilding { get; set; }
        public string Building { get; set; }
        public string Number { get; set; }
        public string DependentThoroughfare { get; set; }
        public string Thoroughfare { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Town { get; set; }
        public string PostalCounty { get; set; }
        public string Postcode { get; set; }
        public string AbbreviatedPostalCounty { get; set; }
        public string OptionalCounty { get; set; }
        public string AbbreviatedOptionalCounty { get; set; }
        public string TraditionalCounty { get; set; }
        public string AdministrativeCounty { get; set; }
        public string DPS { get; set; }
        public string POBox { get; set; }
    } 
}
