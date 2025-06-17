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
    public IActionResult Editar(int id)
    {
        ContatoModels contato = _contatorepos.ListarPorId(id);
        return View(contato);

    }
    public IActionResult ApagarConfirmacao(int id)
{
    ContatoModels contato = _contatorepos.ListarPorId(id);

    return View(contato);
}


    // get para redirecionar quando for apagado 
    [HttpGet]
    public IActionResult Apagar(int id)
    {
        _contatorepos.Apagar(id);
        return RedirectToAction("index");
    }

    [HttpPost]
    public IActionResult Criar(ContatoModels contato)
    {
        _contatorepos.Adicionar(contato);
        return RedirectToAction("index");

    }

    [HttpPost]
    public IActionResult Alterar(ContatoModels contato)
    {
        _contatorepos.Atualizar(contato);
        return RedirectToAction("index");

    }

}


