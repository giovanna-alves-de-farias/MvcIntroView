using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMVC.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Resultado(double num1, double num2, string op)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Op = op;

        switch (op)
        {
            case "Soma":
                ViewBag.Resultado = num1 + num2;
                ViewBag.Sinal = "+";
                break;
                
            case "Subtração":
                ViewBag.Resultado = num1 - num2;
                ViewBag.Sinal = "-";
                break;
                
            case "Multiplicação":
                ViewBag.Resultado = num1 * num2;
                ViewBag.Sinal = "*";
                break;
                
            case "Divisão":
                ViewBag.Resultado = num1 / num2;
                ViewBag.Sinal = "/";
                break;
        }
        return View();
    }
}
