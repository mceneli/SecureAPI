using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace SecureClient{
    class Program{
        static void Main(string[] args){
            AuthConfig config = AuthConfig.ReadJsonFromFile("appsettings.json");

            Console.WriteLine($"Authority: {config.Authority}");
        }
    }
}