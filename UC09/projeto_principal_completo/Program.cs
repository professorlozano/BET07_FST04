using BE7_FS4_UC9.Classes;

using BE7_FS4_UC9.Classes;

Console.Clear();

Console.WriteLine(@$"
===============================================================================
|                    Bem vindo ao sistema de cadastro de                      |
|                       Pessoas Físicas e Jurídicas                           |
===============================================================================
");

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
            //menu de pessoa fisica
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
|                          0 - Retornar ao menu anterior                      |
===============================================================================
");
                opcaoPf = Console.ReadLine(); 

                PessoaFisica metodoPf = new PessoaFisica();
                PessoaFisica novaPf = new PessoaFisica();
                Endereco novoEndPf = new Endereco(); 

                switch (opcaoPf)
                {
                    case "1":
                        //case de cadastrar pessoa fisica
                        Console.Clear();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        Console.WriteLine($"Digite o cpf");
                        novaPf.cpf = Console.ReadLine();


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

                        
                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();
                            
                        if (endCom == "S"){
                            novoEndPf.endComercial = true;
                        }
                        else{
                            novoEndPf.endComercial = false;
                        }
                        novaPf.endereco = novoEndPf;
                        metodoPf.Inserir(novaPf);
                        break;
                    case "2":
                        //case de monstrar pessoa fisica
                        List<PessoaFisica> listaPf = metodoPf.Ler();

                        foreach(PessoaFisica cadaItem in listaPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaItem.nome}
                                CNPJ: {cadaItem.cpf}
                                Razao Social: {cadaItem.dataNascimento}
                                Rendimento: {cadaItem.rendimento}
                                Imposto: {metodoPf.PagarImposto(cadaItem.rendimento).ToString("C")}
                                Logradouro: {cadaItem.endereco.logradouro}
                                Número: {cadaItem.endereco.numero}
                                Complemento: {cadaItem.endereco.complemento}
                                Endereço Comercial?:{((cadaItem.endereco.endComercial)?"Sim":"Não")}
                            ");
                            
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();
                        }
                        break;
                    case "0":
                        //essa opção retornar para o menu anterior, nao vamos inserir nada aqui.
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
             //menu de pessoa juridica
            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir:                         |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Cadastrar Pessoa Juridica                      |
|                          2 - Mostrar Pessoa Juridica                        |
|                                                                             |
|                          0 - Retornar ao menu anterior                      |
===============================================================================
");
                opcaoPj = Console.ReadLine();  

                PessoaJuridica metodoPj = new PessoaJuridica();
                PessoaJuridica novaPj = new PessoaJuridica();
                Endereco novoEndPj = new Endereco();

                switch (opcaoPj)
                {
                    case "1":
                        //case de cadastrar pessoa juridica
                        Console.Clear();

                        Console.WriteLine($"Digite o nome da pessoa juridica que deseja cadastrar");
                        novaPj.nome = Console.ReadLine();

                        bool cnpjValido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ Ex.: 00.000.000/0001-00 ou 00000000000000");
                            string cnpj = Console.ReadLine();

                            cnpjValido = metodoPj.ValidarCnpj(cnpj);
                            if(cnpjValido)
                            {
                                novaPj.cnpj = cnpj;
                            }
                            else{
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Cnpj Inválido, por favor digite um cnpj valido.");
                                Console.ResetColor();
                                
                            } 
                        } while (cnpjValido == false);

                        Console.WriteLine($"Digite a razao social");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();
                            
                        if (endCom == "S"){
                            novoEndPj.endComercial = true;
                        }
                        else{
                            novoEndPj.endComercial = false;
                        }
                        novaPj.endereco = novoEndPj;
                        metodoPj.Inserir(novaPj);
                        break;
                    case "2":
                        //case de mostrar pessoa juridica
                        List<PessoaJuridica> listaPj = metodoPj.Ler();

                        foreach(PessoaJuridica cadaItem in listaPj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Nome: {cadaItem.nome}
                                CNPJ: {cadaItem.cnpj}
                                Razao Social: {cadaItem.razaoSocial}
                                Rendimento: {cadaItem.rendimento}
                                Imposto: {metodoPj.PagarImposto(cadaItem.rendimento).ToString("C")}
                                Logradouro: {cadaItem.endereco.logradouro}
                                Número: {cadaItem.endereco.numero}
                                Complemento: {cadaItem.endereco.complemento}
                                Endereço Comercial?:{((cadaItem.endereco.endComercial)?"Sim":"Não")}
                            ");
                            
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();
                        }
                        break;
                    case "0":
                        //essa opção retornar para o menu anterior, nao vamos inserir nada aqui.
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }
                 
            } while (opcaoPj != "0");
            break;
        case "0":
            BarraCarregamento("Finalizando",100);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
            Thread.Sleep(2000);
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