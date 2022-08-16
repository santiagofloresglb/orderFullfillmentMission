using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OrderFullfillment.Application.Interfaces;
using OrderFullfillment.Application.Services;
using OrderFullfillment.Entity.Models;
using OrderFullfillment.Entity.Models.Invoice;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Repository;
using OrderFullfillment.Repository.InvoiceRepository;
using OrderFullfillment.Repository.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFullfillment
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderFullfillment", Version = "v1" });
            });

            services
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IInvoiceService, InvoiceService>()
                .AddScoped<IRepository<InvoiceOrder>, InvoiceOrderRepository>()
                .AddScoped<IRepository<CompanyInvoice>, CompanyInvoiceRepository>()
                .AddScoped<IRepository<PersonalInvoice>, PersonalInvoiceRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrderFullfillment v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
