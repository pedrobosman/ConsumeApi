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
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Olá! Digite o CEP para descobrir sua Localidade: ");
                string cep = Console.ReadLine();

                string baseUrl = "https://viacep.com.br";
                try
                {
                    var cepClient = RestService.For<ICepApiService>(baseUrl);

                    Console.WriteLine("Consultando os dados do Cep: " + cep);

                    var address = await cepClient.GetAddressAsync(cep);

                    Console.WriteLine(address.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                Console.WriteLine("Deseja Pesquisar outro CEP? (Digite sim ou Digite qualquer coisa para sair)");
                flag = ("sim" == Console.ReadLine()) ? true : false;
                Console.Clear();
            }
        }
    }
}
