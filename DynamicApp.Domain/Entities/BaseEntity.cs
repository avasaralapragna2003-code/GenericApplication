using System;

namespace DynamicApp.Domain.Entities
{
    public abstract class BaseEntity
    {
        public string CreatedBy { get; set; } = "System";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = "System";
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
    }
}
