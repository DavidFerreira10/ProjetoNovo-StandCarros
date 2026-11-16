using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoNovo.Models;
using ProjetoNovo.Models.dados;

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
        var dados = new dadosViewModel
        {
             Carros = new List<Carro>
            {
                new Carro ("Ferrari 812", 300000),
                new Carro ("Bugatti Chiron",2000000),
                new Carro ("Ford Mustang FastBack 1969",150000),
            },

            carroUsado = new List<CarrosUsados>
            {
                new CarrosUsados ("Audi A4", 3000,2003),
                new CarrosUsados ("Toyota Yaris",2700,2006),
                new CarrosUsados ("Ford Focus",1500,2013),
            },

            Cliente = new Cliente("David", "ola@gmail.com"),

        };
        

        /*List<Carro> carfilter = new List<Carro>();
        
        foreach (var carro in dados.Carros)
        {
            if(carro._nome == marca)
            {
                carfilter.Add(carro);
            }
        }
        dados.Carros = carfilter;*/

       

        return View(dados);
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
