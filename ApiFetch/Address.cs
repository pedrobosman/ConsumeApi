using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Text;

namespace ApiFetch
{
    public class Address
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("unidade")]
        public string Unidade { get; set; }

        [JsonProperty("ibge")]

        public long Ibge { get; set; }

        [JsonProperty("gia")]

        public string Gia { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendLine();
            print.AppendLine($"CEP: {Cep}");
            print.AppendLine($"Logradouro: {Logradouro}");
            print.AppendLine($"Complemento: {Complemento}");
            print.AppendLine($"Bairro: {Bairro}");
            print.AppendLine($"Localidade: {Localidade}");
            print.AppendLine($"Uf: {Uf}");
            print.AppendLine($"Unidade: {Unidade}");
            print.AppendLine($"Ibge: {Ibge}");
            print.AppendLine($"Gia: {Gia}");


            return print.ToString();
        }
    }
}
