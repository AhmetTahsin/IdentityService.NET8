using IdentityService.Models.Enums;
using IdentityService.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Models.Entities
{
    public class AppUser : IdentityUser<int>,IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}
