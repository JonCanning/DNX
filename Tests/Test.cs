using Xunit;
using Microsoft.AspNet.TestHost;
using CTM.Postcode.Service;
using Microsoft.Framework.Runtime.Infrastructure;
using Microsoft.Framework.Runtime;
using Microsoft.AspNet.Hosting;
using System.Net.Http;
using Newtonsoft.Json;
using CTM.Postcode.Service.models;
using System.Collections.Generic;
public class Test{
	HttpClient client;

	public Test(){
		var environment = CallContextServiceLocator.Locator.ServiceProvider.GetService(typeof(IApplicationEnvironment)) as IApplicationEnvironment;
 		var hostingEnvironment = new HostingEnvironment(environment);
        var startup = new Startup(hostingEnvironment);
		var testServer = TestServer.Create(x => startup.Configure(x, hostingEnvironment), startup.ConfigureServices);
		client = testServer.CreateClient();
	}
	
	[Fact]
	public async void ThisShouldWork(){
		var response = await client.GetAsync("/addresses/foo/bar");
		
		var result = response.Content.ReadAsStringAsync().Result;
		
		var address =  JsonConvert.DeserializeObject<List<Address>>(result);
		
		Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
	    Assert.NotNull(address);
		Assert.Equal(1, address.Count);
	}
}