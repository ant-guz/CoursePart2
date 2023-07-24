using HW2.Interface;
using HW2.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CarAgeMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public CarAgeMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            IManagementCars car = new SimpleCar("BMW", 2500, 7);
            var path = context.Request.Path;
            if (path == "/careAge")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync($"Car age is {car.GetCarAge()}");
            }
            else
            {
                await requestDelegate.Invoke(context);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CarAgeMiddlewareExtensions
    {
        public static IApplicationBuilder UseCarAgeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CarAgeMiddleware>();
        }
    }
}
