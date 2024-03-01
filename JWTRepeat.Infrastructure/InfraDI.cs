using JWTRepeat.Application.Abstractions;
using JWTRepeat.Infrastructure.Persistance;
using JWTRepeat.Infrastructure.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTRepeat.Infrastructure
{
    public static class InfraDI
    {
        public static IServiceCollection AddJWTContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JWTRepeatDbContext>(ops =>
            {
                ops.UseNpgsql(configuration.GetConnectionString(""));
            });
            services.AddScoped<IUserRepository, UserRepository>();
            return services;

        }
    }
}
