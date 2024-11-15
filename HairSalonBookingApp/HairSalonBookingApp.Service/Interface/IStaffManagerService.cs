﻿using HairSalonBookingApp.BusinessObjects.DTOs.StaffManager;
using HairSalonBookingApp.BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Services.Interface
{
    public interface IStaffManagerService
    {
        Task<List<StaffManager>> GetAllStaffManager();
        Task<StaffManager?> GetStaffManagerById(Guid managerId);
        Task<bool> CreateStaffManager(CreateStaffManagerRequest createStaffManagerRequest);
        Task<(bool, string)> UpdateStaffManager(UpdateStaffManagerRequest updateStaffManagerRequest);
        Task<bool> DeleteStaffManager(Guid managerId);
    }
}
