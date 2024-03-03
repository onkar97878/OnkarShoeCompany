using OnkarShoeCompany.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace OnkarShoeCompany
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<OnkarShoeCompanyContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("OnkarShoeCompanyContext")));
        }
    }
}