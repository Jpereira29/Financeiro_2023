using Domain.Interfaces.Generics;
using Domain.Interfaces.IDespesa;
using Entites.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioDespesa : RepositoryGenerics<Despesa>, InterfaceDespesa
    {
        public Task<IList<Despesa>> ListaDespesaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Despesa>> ListaDespesaUsuarioNaoPagasAnteriores(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
