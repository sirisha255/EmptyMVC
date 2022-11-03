using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

   public class Program
   {
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllersWithViews();
        builder.Services.AddMvc();

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(20);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;

        });

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");

            app.UseHsts();
        }

        app.UseHttpsRedirection();
        //app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseSession();

        app.UseRouting();

        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {

            endpoints.MapControllerRoute(
               name: "PreflangCustomRoute",
               pattern: "PreferdLanguage",
               defaults: new { controller = "Demo", action = "PreFerdLanguageCookie" }
               );

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

        });


        app.Run();

    }

   }


  

