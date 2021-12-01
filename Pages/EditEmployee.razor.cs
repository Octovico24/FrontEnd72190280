using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor72190280.Models;
using Blazor72190280.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor72190280.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public NavigationManager NavigationManager { get; set; }
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetById(int.Parse(Id));
            Departments = (await DepartmentService.GetAll()).ToList();
        }
            protected async Task HandleValidSubmit(){
                Employee result = await EmployeeService.Update(int.Parse(Id),Employee);
                NavigationManager.NavigateTo("employeepage");
            }
        
    }
}