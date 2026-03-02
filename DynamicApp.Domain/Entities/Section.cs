using System.Collections.Generic;

namespace DynamicApp.Domain.Entities
{
    public class Section : BaseEntity
    {
        public int SectionId { get; set; }
        public int PageId { get; set; }
        public string SectionTitle { get; set; } = string.Empty;
        public int SectionOrder { get; set; }

        public virtual Page Page { get; set; } = null!;
        public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
    }
}
