using Microsoft.AspNetCore.Mvc;
using InventarioWeb.Models;
using System.Text.Json;

namespace InventarioWeb.Controllers
{
    public class ProductosController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductosController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7058/api/Productos");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<Producto>());
            }

            var json = await response.Content.ReadAsStringAsync();

            var productos = JsonSerializer.Deserialize<List<Producto>>
            (
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            );

            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}