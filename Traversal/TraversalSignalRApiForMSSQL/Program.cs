
using Microsoft.EntityFrameworkCore;
using TraversalSignalRApiForMSSQL.DAL;
using TraversalSignalRApiForMSSQL.Hubs;
using TraversalSignalRApiForMSSQL.Models;

namespace TraversalSignalRApiForMSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<VisitorService>();

            builder.Services.AddSignalR();

            builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .SetIsOriginAllowed((host) => true)
                           .AllowCredentials();
                }));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<TraversalSignalRApiForMSSQLContext>(options =>
            options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.MapControllers();

            app.MapHub<VisitorHub>("/VisitorHub");

            app.Run();
        }
    }
}
