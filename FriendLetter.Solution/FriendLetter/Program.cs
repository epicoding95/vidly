using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter
{
      public class Program
  {
    ////inital start to the program
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
 
}