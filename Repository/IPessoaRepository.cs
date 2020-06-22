using System.Collections.Generic;
using webAPI.Model;

namespace webAPI.Repository
{
    public interface IPessoaRepository
    {
         IEnumerable<Pessoa> GetAll();
    }
}