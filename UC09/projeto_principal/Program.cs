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

List<PessoaFisica> listaPf = new List<PessoaFisica>();


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
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;
            do
            {
                    Console.Clear();
                    Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir:                         |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Cadastrar Pessoa Física                        |
|                          2 - Mostrar Pessoa Física                          |
|                                                                             |
|                          0 - Sair                                           |
===============================================================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();
            
                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de Nascimento Ex.: DD/MM/AAAA");
                            string dataNasc =  Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);

                            if(dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é inválida, por favor digite uma data válida");
                                Console.ResetColor();
                            }
                            
                            } while (dataValida == false);

                            Console.WriteLine($"Digite o número do CPF");
                            novaPf.cpf = Console.ReadLine();

                            Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                            novaPf.rendimento = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o logradouro");
                            novoEnd.logradouro = Console.ReadLine();

                            Console.WriteLine($"Digite o número");
                            novoEnd.numero = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
                            novoEnd.complemento = Console.ReadLine();

                            Console.WriteLine($"Este endereço é comercial? S ou N");
                            string endCom = Console.ReadLine().ToUpper();
                            
                            if (endCom == "S"){
                                novoEnd.endComercial = true;
                            }
                            else{
                                novoEnd.endComercial = false;
                            }
                            novaPf.endereco = novoEnd;
                            listaPf.Add(novaPf);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        break;
                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0){
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();
                            }
                        }
                        else{
                            Console.WriteLine($"Lista Vazia!!!");
                            Thread.Sleep(3000);
                        }

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }
                

            } while (opcaoPf != "0");

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
                CNPJ é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj)?"Sim":"Não")}
                Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
                ");
                
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





