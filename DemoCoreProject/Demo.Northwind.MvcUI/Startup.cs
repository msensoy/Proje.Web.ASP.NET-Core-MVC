using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Northwind.BLL.Abstract;
using Demo.Northwind.BLL.Concrete;
using Demo.Northwind.DAL.Abstract;
using Demo.Northwind.DAL.Concrete.EntityFramework;
using Demo.Northwind.MvcUI.Entities;
using Demo.Northwind.MvcUI.Middlewares;
using Demo.Northwind.MvcUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Northwind.MvcUI
{

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) // servis yapılandırmaları , bağımlılık kontrolleri yapılır dependency inj. 
        {
            services.AddMvc();  // bağımlılıklar için otomatik olarak oluşturulmuş pakettir.
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddScoped<ICartService, CartService>();
            services.AddDbContext<CustomIdentityDbContext>
                (options => options.UseSqlServer("Server=DESKTOP-G07JB9C\\SQLEXPRESS;Database=Northwind;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();
           
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) // orta katman (Middleware) yapılandırılması yapılır. klasik asp.net uygulamasına göre ciddi performans artışı gösterir , kullandığın kadar öde mantığı burda .. hata yakalama süreçleri , loglama vs. burda yapılabilir.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // 1.Middleware : Hata yönetimi 
            }

            // app.UseStaticFiles(); // 2.Middleware : Statik dosya yönetimi  
            // wwwroot klasörünü erişeme açar , tarayıcı tarafından ulaşılabilmesi için bu kod lazım aksi takdirde css , js , img ler vs gözükmez

            app.UseNodeModules(env.ContentRootPath);

            //app.UseMvcWithDefaultRoute(); // 3.Middleware : Routing yönetimi 
            // default olarak home controller ın Index sayfasına git aşağıdakinin aynısı

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}

