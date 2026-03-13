



//using Microsoft.EntityFrameworkCore;
//using MyVokabulary.Repository.Data;

//namespace MyVocabulary.Web
//{
//    public class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddRazorPages();
//            services.AddDbContext<MyVocabularyContext>();
//        }
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (!env.IsDevelopment())
//            {
//                app.UseHsts();
//            }

//            app.UseRouting();
//            app.UseHttpsRedirection();
//            app.UseDefaultFiles();
//            app.UseStaticFiles();
//            app.UseEndpoints(endpoints=> {
//                endpoints.MapRazorPages();
//                endpoints.MapGet("/hello", () => "Hello World"); });
//        }
//    }
//}
