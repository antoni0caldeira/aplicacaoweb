using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers;

public class TabuadaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [Route("/tabuada/{op1}")]
    public String tabuadaSimples(int op1)
    {
        String s = "";
        for (int i = 1; i < 10; i++)
        {
            s = s + op1 + " x " + i + " =  " + (op1 * i)  + "\n";
        }
        return s;
    }

}
    
