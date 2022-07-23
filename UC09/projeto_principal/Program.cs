// See https://aka.ms/new-console-template for more information

using BE7_FS4_UC9.Classes;


Console.WriteLine(@$"
===============================================================================
|                    Bem vindo ao sistema de cadastro de                      |
|                       Pessoas Físicas e Jurídicas                           |
===============================================================================
");
/* codigo comentado devido a ter sido criado um método estatico para evitar a repetição de codigo.
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Carregando ");

for (var contador = 0; contador < 34; contador++)
{
    Console.Write(". ");
    Thread.Sleep(100);
}

Console.ResetColor();
*/
BarraCarregamento("Carregando",100);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir:                         |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Pessoa Física                                  |
|                          2 - Pessoa Jurídica                                |
|                                                                             |
|                          0 - Sair                                           |
===============================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        case "2":
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
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");
            
            /*codigo comentado devido a ter sido criado um método estatico para evitar a repetição de codigo.
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Finalizando");

            for (var contador = 0; contador < 34; contador++)
            {
                Console.Write(". ");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            */
            BarraCarregamento("Finalizando",200);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 34; contador++)
        {
        Console.Write(". ");
        Thread.Sleep(tempo);
        }
    Console.ResetColor();
}





