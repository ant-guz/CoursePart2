using HW2.Interface;
using HW2.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HW2.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CarEngineMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public CarEngineMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            IManagementCars car = new SimpleCar("BMW", 2500, 7);
            var path = context.Request.Path;
            if (path == "/careEngine")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync($"Car engine is {car.GetCarEngine}");
            }
            else
            {
                await requestDelegate.Invoke(context);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CarEngineMiddleware1Extensions
    {
        public static IApplicationBuilder UseCarEngineMiddleware1(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CarEngineMiddleware>();
        }
    }
}
