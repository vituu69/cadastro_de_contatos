using Cursos.Models;
using Cursos.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Controllers;

public class ContatoController : Controller
{

    private readonly IContatoRepos _contatorepos;
    public ContatoController(IContatoRepos contatoRepos)
    {
        _contatorepos = contatoRepos;
    }
    public IActionResult Index()
    {
        var contatos = _contatorepos.BuscarTodos();
        return View(contatos);

    }
    public IActionResult Criar()
    {
        return View();

    }
    public IActionResult Editar()
    {
        return View();

    }
    public IActionResult ApagarConfirmacao()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Criar(ContatoModels contato)
    {
        _contatorepos.Adicionar(contato);
        return RedirectToAction("index");

    }


}


