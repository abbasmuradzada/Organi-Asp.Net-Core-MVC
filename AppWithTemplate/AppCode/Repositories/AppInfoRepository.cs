using AppWithTemplate.Models.DataContext;
using AppWithTemplate.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithTemplate.AppCode.Repositories
{
    public class AppInfoRepository
    {
        private readonly OrganiDbContext db;
        public AppInfoRepository(OrganiDbContext db)
        {
            this.db = db;
        }
        public AppInfo GetInfo()
        {
            var info = db.AppInfo
                .OrderByDescending(a=>a.Id)
                .FirstOrDefault(a => a.DeletedDate == null);


            return info;
        }
    }
}
