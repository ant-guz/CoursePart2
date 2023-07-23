using HW2.Interface;
using HW2.Model;
using HW2.Middleware;

namespace HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();
            {
                //// Add services to the container.
                //builder.Services.AddRazorPages();

                //// Configure the HTTP request pipeline.
                //if (!app.Environment.IsDevelopment())
                //{
                //    app.UseExceptionHandler("/Error");
                //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //    app.UseHsts();
                //}

                //app.UseHttpsRedirection();
                //app.UseStaticFiles();

                //app.UseRouting();

                //app.UseAuthorization();

                //app.MapRazorPages();
            }


            app.UseMiddleware<CarNameMiddleware>();
            app.UseMiddleware<CarAgeMiddleware>();
            app.UseMiddleware<CarEngineMiddleware>();


            app.Run();
        }
    }
}