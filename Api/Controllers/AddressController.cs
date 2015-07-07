using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;

namespace CTM.Postcode.Service.Controllers
{
  public class AddressController : Controller
  {
    PostcodeAnywhereLookup.Service lookupService;

    public AddressController(PostcodeAnywhereLookup.Service lookupService)
    {
      this.lookupService = lookupService;
    }

    [HttpGet]
    [Route("addresses/{postcode}/{houseNumber}")]
    public async Task<PostcodeAnywhereLookup.PostOfficeAddress[]> Get(string postcode, string houseNumber)
    {
      var postOfficeAddresses = await lookupService.Lookup(postcode, houseNumber);
      return postOfficeAddresses;
    }

    [HttpGet]
    [Route("addresses/{postcode}")]
    public async Task<PostcodeAnywhereLookup.PostOfficeAddress[]> Get(string postcode)
    {
      return await Get(postcode, null);
    }
  }
}
