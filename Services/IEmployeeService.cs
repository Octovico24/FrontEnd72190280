using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor72190280.Models;

namespace Blazor72190280.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee employee);
        Task<Employee> Update(int id, Employee employee);
        Task<Employee> Delete(int id);
    }
}