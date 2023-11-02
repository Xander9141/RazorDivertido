using Microsoft.AspNetCore.Mvc;

namespace ProyectoPeliculas.Controllers;

public class PrincipalController : Controller{
    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        return View("Index");

    }

    


}