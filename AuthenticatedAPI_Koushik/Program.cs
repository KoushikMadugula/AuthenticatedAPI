using AuthenticatedAPI_Koushik.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDataContext>(
    options => options.useInMemoryDatabase("DataDB")
    
);

builder.Services.AddDbContext<AppSecurityContext>(
    options => options.useInMemoryDatabase("SecurityDB")
    
);

builder.Services.AddAuthorization();

builder.Services.AddIdendityApiEndpoints<IdentityUser>()
        .AddEntityFrameworkStores<AppSecurityContext>

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

app.MapIdentityApi<IdentityUser>();

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
