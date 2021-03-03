using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithTemplate.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? DeletedDate { get; set; }

        //lazy loading
    }
}
