using EnR2_uc9.Interfaces;

namespace EnR2_uc9.Classes
{
    public class Pessoa : IPessoa
    {
        public string ?nome {get; set;}
        public string ?endereco {get; set;}
        public string ?rendimento { get; set; }
        public float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }


}   