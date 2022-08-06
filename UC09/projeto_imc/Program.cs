// See https://aka.ms/new-console-template for more information
using projeto_imc;

Pessoa obj_pessoa = new Pessoa(98, 1.78);

//double imc = obj_pessoa.calcularIMC(obj_pessoa.peso, obj_pessoa.altura);
//string classificacao = obj_pessoa.classificarIMC(obj_pessoa.imc);
Console.WriteLine(obj_pessoa.imc);
Console.WriteLine(obj_pessoa.classificarIMC(obj_pessoa.imc));




