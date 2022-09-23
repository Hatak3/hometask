using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Https_Json
{
    public class https_json
    {
        static string path = @"C:\Users\MSI\source\repos\ConsoleApp7\ConsoleApp7\Http Jason\TextFile1.txt";
        static async Task Main(string[] args)
        {
            Console.WriteLine("Please enter the url you want");
            string url = Console.ReadLine();
            var awaiter = await GetToDoAsync(url);


            if (awaiter != null)
            {
                File.WriteAllText(path, awaiter.ToString());
            }
            Console.WriteLine("Press X to Exit");
            Console.ReadKey();
        }
        public static async Task<string> GetToDoAsync(string url)
        {
            // const string url = "https://jsonplaceholder.typicode.com/todos";
           // HttpClient client = new HttpClient();
           // Console.WriteLine(strginResult);
            using var client = new HttpClient();
            var strginResult = await client.GetStringAsync(url);
            return strginResult;
        }

    }
}
