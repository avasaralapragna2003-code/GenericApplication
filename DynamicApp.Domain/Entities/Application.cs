using System.Collections.Generic;

namespace DynamicApp.Domain.Entities
{
    public class Application : BaseEntity
    {
        public int ApplicationId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? TermsAndConditions { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Flow> Flows { get; set; } = new List<Flow>();
    }
}
