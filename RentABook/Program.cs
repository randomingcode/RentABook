using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentABook.Data;
using RentABook.Interfaces;
using RentABook.Repository;

namespace RentABook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            

            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IPriceRepository, PriceRepository>();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Data Source=DESKTOP-TBT33NR;Initial Catalog=RentABookDb;Integrated Security=True;Connect Timeout=100;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            });

            var app = builder.Build();

            if (args.Length >0 && args[0].ToLower() == "seeddata")
            {
                
                Seed.SeedData(app);

            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
