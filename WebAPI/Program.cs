
using Business.Interfaces;
using Business.Services;
using Common.Configurations;
using Common.Interfaces;
using Common.Mappers;
using Repository.Interfaces;
using Repository.Repositories;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSingleton<ICreateUserService, CreateUserService>();
            builder.Services.AddSingleton<ICreateUserMapper, CreateUserMapper>();
            builder.Services.AddSingleton<ICreateUserRepository, CreateUserRepository>();
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
