﻿using HairSalonBookingApp.BusinessObjects.DTOs.Branch;
using HairSalonBookingApp.BusinessObjects.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Service.Interface
{
    public interface IBranchService
    {
        Task<ActionResult> AddBranch(CreateBracnhRequest createBracnh, HttpContext httpContext);
        Task<bool> UpdateBranch(Guid branchId, UpdateBranchRequest updateBranchRequest);
        Task<bool> DeleteBranch(Guid branchId);
        Task<ActionResult<List<Branch>>> GetAllBranches();
        Task<ActionResult<Branch>> GetBranchById(Guid branch);
        Task<List<Branch>> GetBranchesByStaffManager(Guid staffManagerId);
    }
}
