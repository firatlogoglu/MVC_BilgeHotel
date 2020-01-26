using MVC_BilgeHotel.MODEL.Entities;
using MVC_BilgeHotel.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.SERVICE.Options
{
    public class CustomerService : BaseService<Customer>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public bool CheckCustomerUsers(string _email, string _password)
        {
            return Any(x => x.EmailAddress == _email && x.Password == _password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tcno">TC Kimlik No'su giriniz</param>
        /// <returns></returns>
        public bool CheckCustomerTCNO(string _tcno)
        {
            return Any(x => x.TCNO == _tcno && x.User==false);
        }

        public bool CheckCustomerTCNOs(string _tcno)
        {
            return Any(x => x.TCNO == _tcno && x.User == true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_email">E-Posta Adresini Giriniz</param>
        /// <returns></returns>

        public bool CheckEmailAd(string _email)
        {
            return Any(x => x.EmailAddress == _email);
        }
    }
}
