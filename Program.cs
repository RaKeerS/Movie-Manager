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
            builder.Services.AddSwaggerDocument(configure => 
                configure.PostProcess = document =>
                {
                    document.Info.Version = "v1.0";
                    document.Info.Title = "Movie Manager API";
                    document.Info.Description = "A Movie Manager Project with Basic implementation";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Srikar Naidu",
                        Email = "n.srikar22@gmail.com",
                        Url = "https://github.com/RaKeerS/Movie-Manager"
                    };
                }
            );
            builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("MovieDBConnectionString")));
            builder.Services.AddScoped<MovieModel>();

            var app = builder.Build();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Movie}/{action=GetMovies}/{id?}");
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.Run();
        }
    }
}