using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithTemplate.Models.Entity
{
    public class AppInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string HashTag { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string PinterestLink { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
