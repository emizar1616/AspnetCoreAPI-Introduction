using AspNetCoreMvc_WithAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AspNetCoreMvc_WithAPI.Controllers
{
    public class CityController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CityController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var http = _httpClientFactory.CreateClient(); //httpClient nesnesi oluşur.
            var result = await http.GetAsync("https://localhost:7014/api/Cities"); //Bu bizim domainimiz ya da buna karşılık gelen portumuz. 
            if (result.IsSuccessStatusCode)
            {
                var jsonData = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<CityViewModel>>(jsonData); //Json serialize işlemleri için Newtonsoft.Json paketini projeye yüklemeliyiz.
                return View(data);
            }
            return View();
        }
    }
}
