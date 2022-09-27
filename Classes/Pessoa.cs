using EnR2_uc9.Interfaces;
using System.Text.RegularExpressions;

namespace EnR2_uc9.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string ?nome {get; set;}
        public Endereco ?endereco {get; set;}
        public float rendimento { get; set; }


        public abstract float PagarImposto(float rendimento);
        
       

    
        
        
    
       
    }


}   