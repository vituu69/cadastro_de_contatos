using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cursos.Data;
using Cursos.Models;

namespace Cursos.Repositories;

public class ContatoRepos : IContatoRepos
{
    //variavel privada para acessar os metodos somente nessa classe 
    //necessidade feita para poder pegar as variaveis do banco BancoContext

    private readonly BancoContext _bancoContext;
    
    public ContatoRepos(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }
    public List<ContatoModels> BuscarTodos()
    {
        // listando tudo que esta no banco de dados para esse cara 
        return _bancoContext.Contatos.ToList();
    }

    public ContatoModels Adicionar(ContatoModels contato)
    {
        // gravar no banco de dados 
        _bancoContext.Contatos.Add(contato);
        _bancoContext.SaveChanges();
        return contato;
    }

    // contrutor do botao editar
    public ContatoModels ListarPorId(int id)
    {
        return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
    }

    public ContatoModels Atualizar(ContatoModels contato)
    {
        ContatoModels contatoDB = ListarPorId(contato.Id);
        if (contatoDB == null) throw new Exception("ouve um erro na atualizacao de contato");
        contatoDB.Nome = contato.Nome;
        contatoDB.Email = contato.Email;
        contatoDB.Celular = contato.Celular;

        _bancoContext.Contatos.Update(contatoDB);
        _bancoContext.SaveChanges();

        return contatoDB;
    }

    public bool Apagar(int id)
    {
        ContatoModels contatoDB = ListarPorId(id);

        if(contatoDB == null) throw new Exception("erro ao apagar");

        _bancoContext.Contatos.Remove(contatoDB);
        _bancoContext.SaveChanges();

        return true;
    }
}