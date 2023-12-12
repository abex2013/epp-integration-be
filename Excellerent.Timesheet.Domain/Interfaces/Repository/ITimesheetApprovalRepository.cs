using Excellerent.SharedModules.Seed;
using Excellerent.Timesheet.Domain.Models;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Interfaces.Repository
{
    public interface ITimesheetApprovalRepository : IAsyncRepository<TimesheetApproval>
    {
        Task UpdateProjectApprovalStatus(TimesheetApproval timesheetApproval);
    }
}
