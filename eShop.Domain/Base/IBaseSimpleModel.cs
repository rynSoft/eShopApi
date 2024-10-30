using System;

namespace eShop.Domain
{
    public interface IBaseSimpleModel
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
        Guid? CreatorId { get; set; }
        Guid? EditorId { get; set; }
        DateTimeOffset? CreateDate { get; set; } 
        DateTimeOffset? EditDate { get; set; }
     
    }
}
