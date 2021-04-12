
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EmployeeManagement.Models;

namespace EmployeeManagement.API.Models
{
    public interface IDepartmentRepository
    {
        public Task<IEnumerable<Department>> GetDepartments();

        public Task<Department> GetDepartment(int departmentId);
    }
}
