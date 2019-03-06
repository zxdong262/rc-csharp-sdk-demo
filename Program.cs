using System;
using System.Threading.Tasks;
using dotenv.net;
using RingCentral;

namespace rc_csharp_sdk_demo
{

  class Program
  {
    static void Main(string[] args)
    {
      DotEnv.Config();
      Console.WriteLine("Hello World!");
      MainAsync().Wait();
    }
    static async Task MainAsync()
    {
      using (var rc = new RestClient(
          Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
          Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
          Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
      ))
      {
        await rc.Authorize(
            Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
            Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
            Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
        );
        var result = await rc.Restapi().Account().Get();
        Console.WriteLine(result);
      }
    }
  }
}
