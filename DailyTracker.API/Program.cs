using DailyTracker.API.Data;
using DailyTracker.API.Mappings;
using DailyTracker.API.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DailyTrackerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DailyTrackerConnectionString"))
);

builder.Services.AddScoped<ITrackerRepository, SQLTrackerRepository>();
builder.Services.AddScoped<IParticipantRepository, SQLParticipantRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
