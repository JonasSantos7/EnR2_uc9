// See https://aka.ms/new-console-template for more information
using EnR2_uc9.Classes;
Console.WriteLine(@$"
==============================================================================
|                   Bem vindo ao sistema de cadastro de                      |
|                         Pessoas Físicas e Jurídicas                        |
==============================================================================
");
/*
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Carregando ");
for(var contador = 0; contador < 34; contador ++){
    Console.Write(". ");
    Thread.Sleep(100);
}
*/
BarraCarregamento("Carregando",200);
string? opcao;

do
{
Console.ResetColor();
Console.Clear();
Console.WriteLine(@$"
==============================================================================
|                   Escolhas uma das opções a seguir:                        |
|____________________________________________________________________________|
|                                                                            |
|                          1 - Pessoa Física                                 |
|                          2 - Pesso Jurídica                                |
|                                                                            |         
|                          0 - Sair                                          |
==============================================================================
");
opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        PessoaFisica novaPf = new PessoaFisica();  
        Endereco novoEnd = new Endereco();
        PessoaFisica metodoPf = new PessoaFisica(); 
        novaPf.nome = "Jonas";
        novaPf.dataNascimento = "23/10/1999";
        novaPf.cpf = "02363037677";
        novaPf.rendimento = 2600.0f;
        novoEnd.logradouro = "Sebastiao Moreira";
        novoEnd.numero = 217;
        novoEnd.complemento = "bloco 5";
        novoEnd.endComercial = true;
        novaPf.endereco = novoEnd;     
        Console.WriteLine(@$"
        nome: {novaPf.nome}
        endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novoEnd.complemento}
        Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
        Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")} 
        ");
        Console.WriteLine(@$"
        Aperta 'Enter' para continuar");          
        Console.ReadLine();
        break;
    case "2": 
          PessoaJuridica metodoPj = new PessoaJuridica();
          PessoaJuridica novaPj = new PessoaJuridica();
          Endereco novoEndPj = new Endereco();

          novaPj.nome  = "NomePj";
          novaPj.cnpj = "00000000000100";
          novaPj.razaoSocial = "Razao social";
          novaPj.rendimento = 8000.0f;
          novoEndPj.logradouro = "Sebastiao Moreira";
          novoEndPj.numero = 217;
          novoEndPj.complemento = "bloco 5";
          novoEndPj.endComercial = true;  
          novaPj.endereco = novoEndPj;
          Console.WriteLine(@$"
          nome: {novaPj.nome}
          Razao Social: {novaPj.razaoSocial}
          CNPJ: {novaPj.cnpj}
          CNPJ é valido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
          Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")} 
 ");
    
          Console.WriteLine(@$"
          Aperta 'Enter' para continuar");          
          Console.ReadLine();
        break;
    case "0":
          Console.Clear();
          Console.WriteLine("Obrigado por utilizar nosso sistema ");
          /*
          Console.BackgroundColor = ConsoleColor.Green;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write("Obrigado por utilizar nosso sistema ");
          for(var contador = 0; contador < 34; contador ++){
          Console.Write(". ");
          Thread.Sleep(100);
          }
          Console.ResetColor();
          */
          BarraCarregamento("Finalizando",100);
        break;              
    default:
        Console.Clear();
        Console.WriteLine($"Opção inválida, por favor digite outra opção");
        Thread.Sleep(3000);
        break;} 
} while (opcao != "0");

  void BarraCarregamento(string texto, int tempo){
          Console.BackgroundColor = ConsoleColor.Green;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write($"{texto}");

          for (var contador = 0; contador < 34; contador ++)
               {
                Console.Write(". ");
                Thread.Sleep(tempo);
               }
          Console.ResetColor();     

  }



















