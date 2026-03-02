using System.Collections.Generic;

namespace DynamicApp.Domain.Entities
{
    public class Field : BaseEntity
    {
        public int FieldId { get; set; }
        public int SectionId { get; set; }
        public string FieldName { get; set; } = string.Empty;
        public string? DisplayName { get; set; }
        public string FieldType { get; set; } = "String"; // String, Number, Date, Enum
        public string? MinValue { get; set; }
        public string? MaxValue { get; set; }
        public string? EnumDisplayType { get; set; } // RadioButton, CheckBox
        public int FieldOrder { get; set; }
        public bool IsRequired { get; set; }
        public int? DependsOnFieldId { get; set; }

        public virtual Section Section { get; set; } = null!;
        public virtual ICollection<EnumValue> EnumValues { get; set; } = new List<EnumValue>();
    }
}
