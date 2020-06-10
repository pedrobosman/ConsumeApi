using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiFetch
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string cep = Console.ReadLine();

            string baseUrl = "https://viacep.com.br";
            try
            {
                var cepClient = RestService.For<ICepApiService>(baseUrl);

                Console.WriteLine("Consultando os dados do Cep: " + cep);

                var address = await cepClient.GetAddressAsync(cep);

                Console.WriteLine("Cidade: " + address.Localidade);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
