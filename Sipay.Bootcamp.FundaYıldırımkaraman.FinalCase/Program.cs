using Sipay.Bootcamp.FundaY�ld�r�mkaraman.FinalCase;

namespace Sipay.Bootcamp.FundaY�ld�r�mkaraman.FinalCase;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
