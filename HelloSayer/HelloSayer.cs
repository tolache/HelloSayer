using System;
using Newtonsoft.Json;

namespace HelloSayer
{
    public class HelloSayer
    {
        public static void SayHello(string name, int linesCount)
        {
            Console.WriteLine("HelloSayer version 26");
            for (int i = 1; i <= linesCount; i++)
            {
                Console.WriteLine("Hello {0}! This is line #{1}.", name, i);
            }
        }

        private static string useNewtonsoftJson()
        {
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@microsoft.com",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            return json;
        }
    }
}
