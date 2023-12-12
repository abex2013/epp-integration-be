using Excellerent.SharedModules.DTO;
using Excellerent.SharedModules.Interface.Service;
using Excellerent.SharedModules.Seed;
using Excellerent.Timesheet.Domain.Entities;
using Excellerent.Timesheet.Domain.Helpers;
using Excellerent.Timesheet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Interfaces.Service
{
    public interface ITimesheetApprovalService : ICRUD<TimesheetApprovalEntity, TimesheetApproval>
    {
        Task<IEnumerable<TimesheetApprovalEntity>> GetTimesheetApprovalStatus(Guid tsGuid);

        Task<PredicatedResponseDTO> GetTimesheetApprovals(PaginationParams paginationParams);

        Task<ResponseDTO> GetProjectApprovalStatus(Guid timesheetId, Guid projectId);

        Task<ResponseDTO> UpdateProjectApprovalStatus(TimesheetApprovalEntity entity);

    }
}
