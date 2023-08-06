using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase;
using Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase.DataAccess.FinalcaseDbContext;
using Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase.JWT.JWT_Settings;
using Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase.Middleware;
using System.Text;
using Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase.JWT.JwtAuthenticationMiddleware;

namespace Sipay.Bootcamp.FundaYýldýrýmkaraman.FinalCase;


public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    public void ConfigureServices(IServiceCollection services)
    {

        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApartmentSystem Collection", Version = "v1" });
        });


        //dbcontext ayarlarý
        var dbType = Configuration.GetConnectionString("DbType");
        if (dbType == "Sql")
        {
            var dbConfig = Configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<FinalcaseDbContext>(opts =>
            opts.UseSqlServer(dbConfig));
        }
        else if (dbType == "PostgreSql")
        {
            var dbConfig = Configuration.GetConnectionString("PostgreSqlConnection");
            services.AddDbContext<FinalcaseDbContext>(opts =>
              opts.UseNpgsql(dbConfig));
        }

        //jwt ayarlarý
        var jwtSettings = new JwtSettings
        {
            SecretKey = "2A49DF37289D10E75308E22DD7C9C9B17826858F5DE3AF741A00B4B47C4C2353",
            Issuer = "FinalCase",
            Audience = "FinalCase",
            AccessTokenExpiration = 60 // Token süresi (dakika cinsinden)
        };

        services.AddSingleton(jwtSettings);

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidateIssuer = true,
                ValidIssuer = jwtSettings.Issuer,
                ValidateAudience = true,
                ValidAudience = jwtSettings.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero // Token süresi üzerindeki tolerans ayarý
            };
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApartmentSystem v1"));
        }

        app.UseLoggingMiddleware();

        app.UseJwtAuthenticationMiddleware();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
