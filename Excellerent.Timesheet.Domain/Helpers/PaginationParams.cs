using Excellerent.SharedModules.Seed;
using Excellerent.Timesheet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Helpers
{
    public class PaginationParams

    {
        private const int MaxPageIndex = 50;
        private const ApprovalStatus _status = ApprovalStatus.Requested;
        public DateTime SubmissionDate { get; set; }
        public DateTime Week { get; set; } = DateTime.Now;
        public ApprovalStatus status { get; set; } = _status;
        public int PageIndex { get; set; } = 1;
        private int _PageSize = 10;
        public int PageSize { 
            get => _PageSize; 
            set => PageSize = (value > MaxPageIndex) ? MaxPageIndex : value; 
        }
        public SortOrder sort { get; set; } = SortOrder.Ascending;
    }
}
