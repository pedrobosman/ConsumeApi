using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiFetch
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<Address> GetAddressAsync(string cep);
    }
}
