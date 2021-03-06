using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace HelloWorld
{
	public class Startup{
		public Startup(IHostingEnvironment env){
		}
		
		public void Configure(IApplicationBuilder app,
		IHostingEnvironment env, ILoggerFactory loggerFactory){
		
			app.Run(async(context) => {
				await context.Response.WriteAsync("Hello, World!");
			});
		
		}
	}
}

