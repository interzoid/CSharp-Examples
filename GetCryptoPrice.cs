// Get your API key at www.interzoid.com/register
using System;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.interzoid.com/getcryptoprice?symbol=ETH"),
                Headers =
            {
                { "x-api-key", "YOUR-API-KEY" },
            },
            };
            using var response = client.Send(request);
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
