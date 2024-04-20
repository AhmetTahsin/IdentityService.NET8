using IdentityService.Models.Enums;
using IdentityService.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Models.Entities
{
    public class AppRole : IdentityRole<int>,IEntity
    {
        public AppRole()
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
