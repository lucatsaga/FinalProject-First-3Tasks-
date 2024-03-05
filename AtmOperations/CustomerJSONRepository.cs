using AtmOperations.Logger.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AtmOperations
{
    public class CustomerJSONRepository : IRepository
    {
        private const string _fileLocation = @"C:\Users\Luka\Desktop\FinalProject(new)\AtmOperations\customerLogger1.json";
        private List<Customer> _data = new();

        public CustomerJSONRepository()
        {
            _data = Parse(File.ReadAllText(_fileLocation));
        }

        private static List<Customer> Parse(string input)
        {
            List<Customer> result = JsonSerializer.Deserialize<List<Customer>>(input);

            if (result == null)
            {
                throw new FormatException("Invalid format while deserialization");
            }

            return result;
        }

        private static string ToJson(Customer model)
        {
            string jsonObject = JsonSerializer.Serialize(model);
            return jsonObject;
        }


        public void AddNewCustomer(Customer model)
        {
            model.Id = _data.Max(x => x.Id) + 1;

            var result = ToJson(model);
            //TODO Save()
        }

        public List<Customer> GetAllCustomers()
        {
            if (_data.Count <= 0)
            {
                throw new Exception("Data storage is empty");
            }

            return _data;
        }

        public Customer GetSingleCustomer(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var result = _data.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                throw new NullReferenceException("Item not found");
            }

            return result;
        }

        public void Save(string input)
        {
            throw new NotImplementedException();
        }
    }
}
