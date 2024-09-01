using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;
using Uttaraonline.DBConfig;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Uttaraonline.Interfaces;
using Uttaraonline.Repository;
using Uttaraonline.LoggerInterface;
using Uttaraonline.JWTModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Register your Sql connection here **************************************************************
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<DBContextProduction>(options => options.UseSqlServer(config.GetConnectionString("ProdConnection")));
//Register your Sql connection here********************************************************************

//Dependency Injection//
builder.Services.AddScoped<IServices, ServiceRepository>();
builder.Services.AddScoped<IClient, ClientRepository>();
builder.Services.AddScoped<IServer,ServerReposotory>();
builder.Services.AddScoped<IAuthHandler, AuthHandlerRepository>();
builder.Services.AddScoped<IEventLogger, loggerRepository>();
builder.Services.AddScoped<IRoleManager,RoleManagerRepo>();

builder.Services.AddScoped<IAdmin,AdminRepo>(); 

// Add JWT //
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("Jwt"));
// Add JWT //
var key = builder.Configuration.GetSection("Jwt:Key").Get<string>();
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
        ValidateIssuer = false,
        ValidateAudience = false
        // Add other validation parameters as needed
    };
});


//Add Auth To Swagger//
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Uttaraonline", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
});
//Add Auth To Swagger//
builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot();



//Adding CORS//
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
//Adding CORS//


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
