﻿using HairSalonBookingApp.BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Repositories.Interface
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account? GetByEmail(string email);
    }
}
