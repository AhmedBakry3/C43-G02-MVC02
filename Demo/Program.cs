using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            #region Routing
            #region Static Segment
            //app.MapGet("/Ahmed", () => "Hello Ahned!");

            #endregion

            #region Variable Segment
            //app.MapGet("/{name}", async context =>
            //  {
            //      var Name = context.GetRouteValue("name");
            //      await context.Response.WriteAsync($"hello {Name}");
            //  });
            #endregion

            #region Mixed Segment

            //app.MapGet("/X{name}", async context =>
            //{
            //    //var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"hello {context.Request.RouteValues["name"]}");
            //});
            #endregion

            #region MovieController Routing
            //app.MapControllerRoute(
            //    name: "Default",
            //    pattern: "{Controller}/{Action}/{id?} //Id is optional",
            //    defaults: new  { Controller = "Movies" , Action = "Index"},
            //   constraints: new { id = @"\d{2}" });
            ////constraints: new { id = new IntRouteConstraint() });
            ///


            //app.MapControllerRoute(
            //    name: "Default",
            //    pattern: "{Controller=Movies}/{Action=Index}/{id:regex(^\\d{{2}}$)?} //Id is optional");
            ////defaults: new { Controller = "Movies", Action = "Index" },
            ////constraints: new { id = @"\d{2}" });
            ////constraints: new { id = new IntRouteConstraint() 


            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "Default",
                pattern: "{Controller=Home}/{Action=Index}/{Id:int?}");
            //defaults: new { Controller = "Movies", Action = "Index" },
            //constraints: new { id = @"\d{2}" });
            //constraints: new { id = new IntRouteConstraint() 

            #endregion

            #endregion

            app.Run();
        }
    }
}
