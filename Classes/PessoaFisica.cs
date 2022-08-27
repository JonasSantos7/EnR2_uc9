using EnR2_uc9.Interfaces;

namespace EnR2_uc9.Classes
{
    public class PessoaFisica: Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento {get; set;}
    
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual= DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays /365;
            if(anos >= 18)
                return true;
            else 
                return false;
                           
        }
    }


}
    

 