using System;

namespace DynamicApp.Domain.Entities
{
    public class UserSubmission
    {
        public int SubmissionId { get; set; }
        public Guid SubmissionGroupId { get; set; }
        public int ApplicationId { get; set; }
        public int FieldId { get; set; }
        public string? FieldValue { get; set; }
        public string? Status { get; set; } = "Pending";
        public string? SubmittedBy { get; set; } = "User";
        public DateTime SubmittedAt { get; set; } = DateTime.Now;

        public virtual Application Application { get; set; } = null!;
        public virtual Field Field { get; set; } = null!;
    }
}
