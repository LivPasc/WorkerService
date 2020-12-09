using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerService1.DbContextInit;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<DataAccessContext>();
                    optionsBuilder.UseSqlServer("Server=10.152.220.71,1433; Database=MicrocontrollerDataDB; User=sa; Password=MSSQLPassword2020");//localhost\\SQLEXPRESS; integrated security=true
                    services.AddScoped<DataAccessContext>(s => new DataAccessContext(optionsBuilder.Options));
                    services.AddHostedService<Worker>();
                });
    }
}
