using LojaMVC.NovaPasta1;
using LojaMVC.Repository;
using Microsoft.EntityFrameworkCore;

namespace LojaMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BancoContext>
               (options => options.UseSqlServer("Data Source=DESKTOP-78J62HB;Initial Catalog=CRUD_MVC;User ID=sa;Password=root;TrustServerCertificate=True"));
            // Add services to the container.
            builder.Services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();
            builder.Services.AddScoped<ProdutoInterface, ProdutoRepository>();
                
                   
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}