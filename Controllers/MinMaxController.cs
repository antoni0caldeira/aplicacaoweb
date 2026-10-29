using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Controllers;

public class MinMaxController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [Route("/min/{op1}/{op2}/{op3}")]
    public String min(int op1, int op2, int op3)
    {
        int   min = Math.Min((op1), (op2));
        min = Math.Min(min, (op3));
        
        return "O mínimo é: " + min;
    }
    
    [Route("/max/{op1}/{op2}/{op3}")]            
    public String max(int op1, int op2, int op3) 
    {                                            
        int   max = Math.Min((op1), (op2));      
        max = Math.Min(max, (op3));              
                                             
        return "O máximo é: " + max;             
    }                                            

    
}