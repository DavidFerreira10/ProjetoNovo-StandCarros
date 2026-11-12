using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoNovo.Models;

namespace ProjetoNovo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Comprar()
    {
        return View();
    }

    public IActionResult Vender()
    {
        List<Carro> carros = new List<Carro>
        {
            new Carro { nome = "Audi A4", preco = 3000 },
            new Carro { nome = "Toyota Yaris", preco = 2700 },
            new Carro { nome = "Ford Focus", preco = 1500 },
        };
        return View(carros);
    }
    public IActionResult Alugar()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
