using System.Collections.Generic;

namespace DynamicApp.Domain.Entities
{
    public class Page : BaseEntity
    {
        public int PageId { get; set; }
        public int FlowId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Subtitle { get; set; }
        public int PageOrder { get; set; }

        public virtual Flow Flow { get; set; } = null!;
        public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
