using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Flávio Nery", "857.032.950-41", "flavio@sp.senai.br", "Totó");
        Cliente cliente2 = new Cliente(02, "William Gates", "039.618.250-09", "bill@sp.senai.br", "Miau");
        Cliente cliente3 = new Cliente(03, "Ada Love", "800.777.920-50", "ada@sp.senai.br", "Popó");
        Cliente cliente4 = new Cliente(04, "Linus TUX", "933.622.400-03", "linus@sp.senai.br", "Pinguas");
        Cliente cliente5 = new Cliente(05, "Steve Jobs", "911.702.988-00", "steve@sp.senai.br", "Apple");

        //Lista de Clientes e atribui
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //Instancias dos fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C3 PET SA", "14.182.102/0001-80", "C3@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrk Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "tiktok@noisnamidia.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho forever", "18.760.614/0001-37", "contato@ff.us");
        
        //Lista de Fornecedores e atribui
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
