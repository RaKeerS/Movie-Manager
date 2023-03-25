namespace MovieManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddSwaggerDocument();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}