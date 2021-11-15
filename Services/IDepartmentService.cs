using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor72190280.Models;

namespace Blazor72190280.Services
{
    public interface IDepartmentService
    {
        Task < IEnumerable<Department>> GetAll();
        Task <Department> GetById(int id);
    }
}