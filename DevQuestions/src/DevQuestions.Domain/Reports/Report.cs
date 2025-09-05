using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Domain.Reports
{
    public class Report
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; } // кто отправил жалобу
        public required Guid ReportedUserId { get; set; } // на кого отправили жалобу
        public Status Status { get; set; } = Status.Open;
        public required string Reason { get; set; } // причина жалобы
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? ResolvedByUserId { get; set; } // кто решил проблему
    }

    public enum Status
    {
        Open,
        InProgress,
        Resolved,
        Dismissed
    }
}
