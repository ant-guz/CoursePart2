using HW2.Interface;
using HW2.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CarNameMiddleware
    {
        private readonly RequestDelegate requestDelegate;


        public CarNameMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;

        }

        public async Task InvokeAsync(HttpContext context)
        {
            IManagementCars car = new SimpleCar("BMW", 2500, 7);
            var path = context.Request.Path;
            if (path == "/careName")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync($"Car name is {car.GetCarName}");
            }
            else 
            {
                await requestDelegate.Invoke(context);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CarNameMiddlewareExtensions
    {
        public static IApplicationBuilder UseCarNameMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CarNameMiddleware>();
        }
    }
}
