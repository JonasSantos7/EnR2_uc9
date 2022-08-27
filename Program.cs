// See https://aka.ms/new-console-template for more information
using EnR2_uc9.Classes;

PessoaFisica novaPf = new PessoaFisica();   
/*
novaPf.nome = "Jonas";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
*/
Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(1999,10,23)));



