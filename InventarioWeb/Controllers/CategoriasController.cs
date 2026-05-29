using Microsoft.AspNetCore.Mvc;
using InventarioWeb.Models;
using System.Text.Json;

namespace InventarioWeb.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly HttpClient _httpClient;

        public CategoriasController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7058/api/Categorias");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<Categoria>());
            }

            var json = await response.Content.ReadAsStringAsync();

            var categorias = JsonSerializer.Deserialize<List<Categoria>>
            (
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            );

            return View(categorias);
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