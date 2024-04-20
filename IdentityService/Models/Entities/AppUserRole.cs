using IdentityService.Models.Enums;
using IdentityService.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Models.Entities
{
    public class AppUserRole : IdentityUserRole<int>,IEntity
    {
        public AppUserRole()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relation Properties
        public virtual AppUser AppUser { get; set; }
        public virtual AppRole AppRole { get; set; }
    }
}
