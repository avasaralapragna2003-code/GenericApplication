using System.Collections.Generic;

namespace DynamicApp.Domain.Entities
{
    public class Flow : BaseEntity
    {
        public int FlowId { get; set; }
        public int ApplicationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int FlowOrder { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual ICollection<Page> Pages { get; set; } = new List<Page>();
    }
}
