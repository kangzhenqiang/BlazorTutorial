
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Run(LoadEmployees);
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        private void LoadEmployees()
        {
            //Thread.Sleep(3000);
            var e1 = new Employee()
            {
                EmployeeId=1,
                FirstName="zhenqiang",
                LastName="kang",
                Email="kangzhenqiang@Outlook.com",
                DataOfBrith=new DateTime(1988,06,22),
                Gender=Gender.Male,
                DepartmentId=3,
                PhotoPath="images/kangzhenqiang.png"
            };
            var e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "jing",
                LastName = "wang",
                Email = "wangjing@Outlook.com",
                DataOfBrith = new DateTime(1988, 06, 22),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/wangjing.png"
            };

            Employees = new List<Employee>() { e1, e2 };
        }
    }
}
