﻿using HairSalonBookingApp.Repositories.Interface;
using HairSalonBookingApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Services
{
    public class StaffStylistService : IStaffStylistService
    {
        private readonly IStaffStylistRepository _staffStylistRepository;

        public StaffStylistService(IStaffStylistRepository staffStylistRepository)
        {
            _staffStylistRepository = staffStylistRepository;
        }
    }
}
