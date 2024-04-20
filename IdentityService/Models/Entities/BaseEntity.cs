using IdentityService.Models.Enums;
using IdentityService.Models.Interfaces;

namespace IdentityService.Models.Entities
{
    public class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.UtcNow;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
