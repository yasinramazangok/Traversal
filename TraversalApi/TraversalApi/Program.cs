using TraversalApi.BusinessLayer.Containers;
using TraversalApi.BusinessLayer.Mapping.AutoMapperProfile;
using TraversalApi.DataAccessLayer.Context;

namespace TraversalApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDataAccessAndBusinessLayerServices();

            builder.Services.AddDbContext<TraversalApiContext>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("TraversalApiCors",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            builder.Services.AddAutoMapper(typeof(VisitorMapProfile));

            builder.Services.AddMvc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("TraversalApiCors");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
