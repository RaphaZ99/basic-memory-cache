using BasicMemoryCache.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace BasicMemoryCache.Controllers
{
    [ApiController]
    [Route("api/[controller]/v1")]
    public class ViaCepController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;


        public ViaCepController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("zipCode/{zipCode}")]
        public async Task<IActionResult> GetByZipCode(string zipCode)
        {

            const string urlViaCep = "https://viacep.com.br/ws";

            if (_memoryCache.TryGetValue(zipCode, out ViaCep cepData))
            {
                return Ok(cepData);
            }

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"{urlViaCep}/{zipCode}/json");
                var responseData = await response.Content.ReadAsStringAsync();

                cepData = JsonSerializer.Deserialize<ViaCep>(responseData);


                var memoryCacheEntryExpiration = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(3600),
                    SlidingExpiration = TimeSpan.FromSeconds(3600)
                };

                _memoryCache.Set(zipCode, cepData, memoryCacheEntryExpiration);
                return Ok(cepData);
            }
        }
    }
}
