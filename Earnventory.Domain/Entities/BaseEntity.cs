using System;
using Earnventory.Domain.IEntities;

namespace Earnventory.Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Guid? CreatedBy { get; set; }
        public Guid? LastUpdatedBy { get; set; }
    }
}