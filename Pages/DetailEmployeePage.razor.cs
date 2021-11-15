using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor72190280.Models;
using Blazor72190280.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor72190280.Pages
{
    public partial class DetailEmployeePage
    {
        [Parameter]
        public string id { get; set; }
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetById(Convert.ToInt32(id));
        }
    }
}