using Excellerent.SharedModules.DTO;
using Excellerent.SharedModules.Seed;
using Excellerent.SharedModules.Services;
using Excellerent.Timesheet.Domain.Entities;
using Excellerent.Timesheet.Domain.Helpers;
using Excellerent.Timesheet.Domain.Interfaces.Repository;
using Excellerent.Timesheet.Domain.Interfaces.Service;
using Excellerent.Timesheet.Domain.Mapping;
using Excellerent.Timesheet.Domain.Models;
using Excellerent.Timesheet.Domain.Utilities;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Services
{
    public class TimesheetApprovalService : CRUD<TimesheetApprovalEntity, TimesheetApproval>, ITimesheetApprovalService
    {
        private readonly ITimesheetApprovalRepository _repository;
        private readonly ITimeSheetRepository _timeSheetRepository;

        public TimesheetApprovalService(ITimesheetApprovalRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TimesheetApprovalEntity>> GetTimesheetApprovalStatus(Guid tsGuid)
        {
            var timesheetApprovals = (await _repository.FindAsync(x => x.TimesheetId == tsGuid)).ToList();

            return timesheetApprovals.Select(tsa => new TimesheetApprovalEntity(tsa));
        }

        public async Task<PredicatedResponseDTO> GetTimesheetApprovals(PaginationParams paginationParams)
        {
           


            // return (await _repository.FindAsync(x => x.Status == status)).ToList().Select(a => new TimesheetApprovalEntity(a));
            var timesheetApprovals = await _repository.GetAsync<object>(x => x.Status == paginationParams.status, x => x.CreatedDate, paginationParams.PageIndex, paginationParams.PageSize, paginationParams.sort);
            if (paginationParams.Week  != DateTime.Now)
            {
                DateTime localDateTime = paginationParams.Week;
                localDateTime = (DateTime)localDateTime.Date;
                DateTime fromDate = DateTimeUtility.GetWeeksFirstDate(localDateTime);
                DateTime toDate = DateTimeUtility.GetWeeksLastDate(localDateTime);
                timesheetApprovals = timesheetApprovals.Where(x => (x.Timesheet.FromDate == fromDate) && (x.Timesheet.ToDate == toDate));
            }
            
            int TotalRowCount = await _repository.CountAsync();
            return new PredicatedResponseDTO
            {
                Data = timesheetApprovals.Select(a => new TimesheetApprovalEntity(a).MapToDto()),
                PageIndex = paginationParams.PageIndex,
                PageSize = paginationParams.PageSize,
                TotalRecord = TotalRowCount,
                TotalPage = TotalRowCount % paginationParams.PageSize == 0 ? TotalRowCount / paginationParams.PageSize : TotalRowCount / paginationParams.PageSize + 1
            };
        }
        public async Task<ResponseDTO> GetProjectApprovalStatus(Guid timesheetId, Guid projectId)
        {
            try
            {
                return new ResponseDTO(ResponseStatus.Success, "project approval request", (await GetTimesheetApprovalStatus(timesheetId)).ToList().Find(x => x.ProjectId == projectId));
            }
            catch (Exception ex)
            {
                return new ResponseDTO(ResponseStatus.Success, ex.Message, null);
            }
        }
        public async Task<ResponseDTO> UpdateProjectApprovalStatus(TimesheetApprovalEntity entity)
        {
            try
            {            
                await _repository.UpdateProjectApprovalStatus(entity.MapToModel());

                return new ResponseDTO(ResponseStatus.Success, "status updated successfully", entity);
            }
            catch (Exception ex)
            {
                return new ResponseDTO(ResponseStatus.Error, ex.InnerException.ToString(), entity);
            }

        }
    }
}
