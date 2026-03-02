using System;

namespace DynamicApp.Domain.Entities
{
    public class EnumValue
    {
        public int EnumValueId { get; set; }
        public int FieldId { get; set; }
        public int? ParentEnumValueId { get; set; }
        public string Value { get; set; } = string.Empty;
        public string DisplayLabel { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = "System";
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual Field Field { get; set; } = null!;
    }
}
