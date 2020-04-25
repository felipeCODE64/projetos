using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entidades.Exececoes
{
    class ExececaoConta : Exception
    {
        public ExececaoConta(String mensagem) : base(mensagem)
        {

        }
    }
}
