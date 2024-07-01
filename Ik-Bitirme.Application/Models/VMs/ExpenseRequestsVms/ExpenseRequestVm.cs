﻿using Ik_Bitirme.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik_Bitirme.Application.Models.VMs.ExpenseRequestsVms
{
    public class ExpenseRequestVm
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public double Amount { get; set; }
        public CurrencyType Currency { get; set; }
        public DateTime? ResponseDate { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }

        public byte[]? ImageData { get; set; }
        
        public DateTime RequestDate { get; set; }
    }
}
