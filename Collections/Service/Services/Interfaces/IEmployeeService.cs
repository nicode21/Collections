using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IEmployeeService
    {
        public int GetFilteredEmployeesCount(DateTime start,DateTime end,double salary);
    }
}
