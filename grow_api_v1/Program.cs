using grow_api_v1.Repository;
using grow_api_v1.Repository.DbContext;
using grow_api_v1.Repository.Interfaces;
using grow_api_v1.Services;
using grow_api_v1.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    options.AddPolicy("AllowCorsPolicy", policyBuilder => policyBuilder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin()
    )
);

builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<GrowDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty));

# region Service Layer

builder.Services.AddScoped<IProduceService, ProduceService>();
builder.Services.AddScoped<IGrowService, GrowService>();

# endregion Service Layer

# region Repository Layer

builder.Services.AddScoped<IProduceRepository,ProduceRepository>();
builder.Services.AddScoped<IGrowRepository, GrowRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

# endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("AllowCorsPolicy");

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
