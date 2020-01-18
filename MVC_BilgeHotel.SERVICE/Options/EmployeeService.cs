using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class EmployeeService : BaseService<Employee>
    {
        public bool CheckEmpoyeeUsers(string _email, string _password)
        {
            return Any(x => x.EmailAddress == _email && x.Password == _password);
        }
    }
}
