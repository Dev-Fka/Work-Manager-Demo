using Microsoft.EntityFrameworkCore;
using WorkManager.Database.Abstract;
using WorkManager.Database.Concrete.EFCore;
using WorkManager.Service.Abstract;
using WorkManager.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment env = builder.Environment;

string MyAllowOrigin = "_myOrigin";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WorkContext>(options => options.UseSqlServer(configuration.GetConnectionString("MsSqlConnection")));
builder.Services.AddScoped<IWorkRepo, EFCoreWorkRepo>();
builder.Services.AddScoped<IService, MyWorkManager>();


builder.Services.AddCors(option =>
{
    option.AddPolicy(
        name: MyAllowOrigin,
        builder =>
        {
            builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
        }
    );
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // SeedDatabase.seed();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseCors(MyAllowOrigin);
app.UseAuthorization();

app.MapControllers();

app.Run();
