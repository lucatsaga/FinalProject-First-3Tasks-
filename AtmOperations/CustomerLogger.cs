using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AtmOperations
{
    public class CustomerLogger
    {
        private const string FilePath = @"C:\Users\Luka\Desktop\FinalProject(new)\AtmOperations\customerLogger1.json";
        
        public static List<Customer> LoadCustomers()
        {
            List<Customer> customers;
            string json = File.ReadAllText(FilePath);

            if (!string.IsNullOrEmpty(json))
            {
                customers = JsonSerializer.Deserialize<List<Customer>>(json);
            }
            else
            {
                customers = new List<Customer>();
            }

            return customers;
        }

        public static void SaveCustomer(Customer customer)
        {
            string json = JsonSerializer.Serialize(customer, new JsonSerializerOptions { WriteIndented = true });
            File.AppendAllText(FilePath, json + Environment.NewLine);
        }








    }
}
