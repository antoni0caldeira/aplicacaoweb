using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers;

public class OrdenaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [Route("/ordena/{op1}/{op2}/{op3}")]
    public String ordenasinples(int op1, int op2, int op3)
    {
    int max = Math.Max(op1, op2);
    max = Math.Max(max, op3);
    int min = Math.Min(op1, op2);
    min = Math.Min(min, op3);
    
    return min + " " + (op1 + op2 + op3 - max- min) + " " + max;
    
    }
}