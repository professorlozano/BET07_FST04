// See https://aka.ms/new-console-template for more information

using BE7_FS4_UC9.Classes;

/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "Luiz";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678900";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Alameda BArao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/


/*
novaPf.nome = "Lozano";
Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/
//Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));
//Console.WriteLine(novaPf.ValidarDataNascimento("01-01-2000"));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
novaPj.cnpj = "00000000000100";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Alameda BArao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");






