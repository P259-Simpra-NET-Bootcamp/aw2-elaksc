﻿using Entities.Models;
using Repositories.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        public StaffRepository(SimpDbContext dbContext) : base(dbContext)
        {
        }
    }
}
