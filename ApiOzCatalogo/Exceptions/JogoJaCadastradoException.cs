using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOzCatalogo.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {

        public JogoJaCadastradoException()
            : base("Nobre usuario este jogo já está no banco de dados")
        { }
    }
}
