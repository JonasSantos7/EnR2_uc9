using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnR2_uc9.Interfaces;

namespace EnR2_uc9.Classes
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaosocial {get; set;}




        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}        