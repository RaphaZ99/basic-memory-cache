using System.Text.Json.Serialization;

namespace BasicMemoryCache.Model
{
    public class ViaCep
    {
        [JsonPropertyName("cep")]
        public string ZipCode { get; set; }

        [JsonPropertyName("logradouro")]
        public string Address { get; set; }

        [JsonPropertyName("bairro")]
        public string Neighborhood { get; set; }

        [JsonPropertyName("localidade")]
        public string Locality { get; set; }


        [JsonPropertyName("uf")]
        public string UF { get; set; }

        [JsonPropertyName("gia")]
        public string GIA { get; set; }

        [JsonPropertyName("ddd")]
        public string DDD { get; set; }

        [JsonPropertyName("siafi")]
        public string Siafi { get; set; }
    }
}
