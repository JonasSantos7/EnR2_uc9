using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnR2_uc9.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj (string cnpj);
    }
}