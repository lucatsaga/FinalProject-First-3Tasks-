using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmOperations.Logger.NewFolder
{
    public interface IRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetSingleCustomer(int id);
        void AddNewCustomer(Customer model);
        void Save(string input);
    }
}
