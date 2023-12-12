using Excellerent.SharedModules.Seed;
using Excellerent.Timesheet.Domain.Models;
using System;

namespace Excellerent.Timesheet.Domain.Entities
{
    public class TimesheetApprovalEntity : BaseEntity<TimesheetApproval>
    {
        public Guid TimesheetId { get; set; }
        public Guid ProjectId { get; set; }
        public ApprovalStatus Status { get; set; }
        public string Comment { get; set; }

        public TimesheetApprovalEntity() { }

        public TimesheetApprovalEntity(Guid timesheetId, Guid projectId, ApprovalStatus? status, string comment)
        {
            this.TimesheetId = timesheetId;
            this.ProjectId = projectId;
            this.Status = status ?? ApprovalStatus.Requested;
            this.Comment = comment;
        }

        public TimesheetApprovalEntity(TimesheetApproval timesheetApproval) 
        {
            TimesheetId = timesheetApproval.TimesheetId;
            ProjectId = timesheetApproval.ProjectId;
            Status = timesheetApproval.Status;
            Comment = timesheetApproval.Comment;
        }

        public override TimesheetApproval MapToModel()
        {
            TimesheetApproval timesheetApproval = new TimesheetApproval();
            timesheetApproval.TimesheetId = TimesheetId;
            timesheetApproval.ProjectId = ProjectId;
            timesheetApproval.Status = Status;
            timesheetApproval.Comment = Comment;
            return timesheetApproval;
        }

        public override TimesheetApproval MapToModel(TimesheetApproval tsa)
        {
            TimesheetApproval timesheetApproval = new TimesheetApproval();

            timesheetApproval.TimesheetId = tsa.TimesheetId;
            timesheetApproval.ProjectId = tsa.ProjectId;
            timesheetApproval.Status = tsa.Status;
            timesheetApproval.Comment = tsa.Comment;

            return timesheetApproval;
        }
    }
}
