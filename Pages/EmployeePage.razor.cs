using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor72190280.Models;
using Blazor72190280.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor72190280.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}