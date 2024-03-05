using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmOperations
{
   
    public class FileLogger

    {
        
        private const string _filePath = @$"C:\Users\Luka\Desktop\FinalProject(new)\AtmOperations\Logger\log.txt";
        public static void Log(string message, Customer customer)
        {
            string logEntry = $"{DateTime.Now}: {message}\n";

            // Ensure the file is opened in Append mode with the correct encoding
            using (StreamWriter sw = new StreamWriter(_filePath, true, Encoding.UTF8))
            {
                sw.WriteLine(logEntry);
            }
        }

    }
}
