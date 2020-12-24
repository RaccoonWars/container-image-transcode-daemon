using System;
using System.Threading.Tasks;

namespace RaccoonWars.Transcode
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string configurationFile = Environment.GetEnvironmentVariable("TRANSCODE_CONFIGURATION_PATH");

            if(string.IsNullOrWhiteSpace(configurationFile))
            {

            }


            Console.WriteLine("Hello World!");
        }
    }
}
