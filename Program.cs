// See https://aka.ms/new-console-template for more information
using EnR2_uc9.Classes;
/*
PessoaFisica novaPf = new PessoaFisica();  
Endereco novoEnd = new Endereco();
PessoaFisica metodoPf = new PessoaFisica(); 

novaPf.nome = "Jonas";
novaPf.dataNascimento = "23/10/1999";
novaPf.cpf = "02363037677";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Sebastiao Moreira";
novoEnd.numero = 217;
novoEnd.complemento = "bloco 5";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;
Console.WriteLine(@$"
nome: {novaPf.nome}
endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novoEnd.complemento}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/

/*
novaPf.nome = "Jonas";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine(novaPf.ValidarDataNascimento("22/10/1999"));
*/
PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome  = "NomePj";
novaPj.cnpj = "00000000000000";
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
CNPJ é valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");










