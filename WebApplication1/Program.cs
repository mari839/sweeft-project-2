using WebApplication1.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Services;
using WebApplication1.ApiServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters();

builder.Services.AddDbContext<TeacherPupilContexts>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:TeacherPupilDBConnectionString"]));

builder.Services.AddScoped<ITeacherPupilRepository, TeacherPupilRepository>();
builder.Services.AddScoped<CountryDataFilesGeneratorService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
