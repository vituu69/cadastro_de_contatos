using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta criada por mim
using Cursos.Models;
using Microsoft.VisualBasic;

namespace Cursos.Repositories;

public interface IContatoRepos
{
    // tras os id para o botao editar
    ContatoModels ListarPorId(int id);
    // da umm update no banco
    ContatoModels Atualizar(ContatoModels contato);


    List<ContatoModels> BuscarTodos();
    ContatoModels Adicionar(ContatoModels contato);

    bool Apagar(int id);
}

