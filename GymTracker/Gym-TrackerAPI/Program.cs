using GymTrackersAPI.Repositiories;
using GymTrackersAPI.Data;
using Microsoft.EntityFrameworkCore;
using Gym_TrackerAPI.Repositiories;
using Gym_TrackerDKAPI.Repositories;
using GymTrackerAPI.Repositiories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGymMenu, GymMenu>();
builder.Services.AddScoped<ILocationMenu, LocationMenu>();
builder.Services.AddScoped<IApperalService, ApperalService>();
builder.Services.AddScoped<IExerciseService,  ExerciseService>();

builder.Services.AddDbContext<DbContextClass>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyRazorPagesApp",
        builder =>
        {
            builder.WithOrigins("https://localhost:7168/")
            .AllowAnyHeader()
            .AllowAnyMethod();
        }

        );
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowMyRazorPagesApp");
app.UseAuthorization();

app.MapControllers();

app.Run();
