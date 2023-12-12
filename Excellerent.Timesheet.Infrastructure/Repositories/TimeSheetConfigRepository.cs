﻿using Excellerent.SharedInfrastructure.Context;
using Excellerent.SharedInfrastructure.Repository;
using Excellerent.Timesheet.Domain.Interfaces.Repository;
using Excellerent.Timesheet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Infrastructure.Repositories
{
    public class TimeSheetConfigRepository : AsyncRepository<Configuration>, ITimeSheetConfigRepository
    {
        private readonly EPPContext _context;
        public TimeSheetConfigRepository(EPPContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Configuration>> GetTimeSheetConfiguration()
        {
            return await GetAllAsync();
        }
    }
}
