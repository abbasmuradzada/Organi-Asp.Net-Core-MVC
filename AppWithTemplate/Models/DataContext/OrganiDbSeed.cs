using AppWithTemplate.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithTemplate.Models.DataContext
{
    static public class OrganiDbSeed
    {

        static public void Seed(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<OrganiDbContext>();

                InitAppInfo(db);

                InitProducts(db);
            }
        }

        private static void InitProducts(OrganiDbContext db)
        {
            var category = db.Categories.FirstOrDefault();

        }

        private static void InitAppInfo(OrganiDbContext db)
        {
            if (!db.AppInfo.Any(a => a.DeletedDate == null))
            {
                AppInfo entity = new AppInfo
                {
                    Email = "info@organi.az",
                    HashTag = "#developerləri qoruyaq",
                    PhoneNumber = "+012-312-21-12",
                    Address = "Nizami küçəsi 203B, AF Business House, 2-ci mərtəbə",
                    FacebookLink = "https://www.facebook.com/code.edu.az",
                    InstagramLink = "https://www.instagram.com/code.edu.az",
                };

                db.AppInfo.Add(entity);

                db.SaveChanges();
            }
        }
    }
}
