using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta criada por mim
using Cursos.Models;

namespace Cursos.Repositories;

public interface IContatoRepos
{
    List<ContatoModels> BuscarTodos();
    ContatoModels Adicionar(ContatoModels contato);
}