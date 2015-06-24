using Xunit;
using Microsoft.AspNet.TestHost;
using CTM.Postcode.Service;
using Microsoft.Framework.Runtime.Infrastructure;
using Microsoft.Framework.Runtime;
using Microsoft.AspNet.Hosting;
using System.Net.Http;
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
		var response = await client.GetAsync("/address/foo/bar");
		Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
	}
}