using assignment6.context;
using BLL.Services.Abstract;
using BLL.Services.Implementation;
using DAL.Repo.Abstract;
using DAL.Repo.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<assignment6.context.RouteContext>(options => { options.UseSqlServer("Server=.;Database=myRoute;Trusted_Connection=True;"); });
            builder.Services.AddScoped<IStudnetService, StudnetService>();
            builder.Services.AddScoped<IDepartmentService, DepartmnetService>();
            builder.Services.AddScoped<IDeptartmentRepo, DepartmentRepo>();
            builder.Services.AddScoped<IStudentRepo, StudentRepo>();
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

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Student}/{action=All}/{id?}");

            app.Run();
        }
    }
}