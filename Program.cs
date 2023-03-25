using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using MovieManager.Models;

namespace MovieManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var env = builder.Environment;
            var config = builder.Configuration;

            builder.Services.AddMvc();
            builder.Services.AddSwaggerDocument();
            builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("MovieDBConnectionString")));


            var app = builder.Build();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home/{action=Index}/{id?}");
            });

            app.UseOpenApi();
            app.UseSwaggerUi3();

            //app.MapGet("/", () => "Hello World!");

            //app.Run();
        }
    }
}