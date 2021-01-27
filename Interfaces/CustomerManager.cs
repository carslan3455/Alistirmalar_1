using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_1
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
