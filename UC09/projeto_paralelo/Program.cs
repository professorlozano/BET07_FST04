// See https://aka.ms/new-console-template for more information

using projeto_paralelo;

Console.WriteLine(@$"
*****************************************************************************
*****************************************************************************
*                                                                           *
*             Seja bem vindo ao Sistema de Controle Financeiro              *    
*                                                                           *
*****************************************************************************
*****************************************************************************
");

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Red;

Console.Write("Carregando ");

for (var contador = 0; contador < 10; contador++)
{
    Console.Write(". ");
    Thread.Sleep(500);
}

Console.ResetColor();

Console.Clear();

string? opcao;
do
{
    Console.WriteLine(@$"
*****************************************************************************
*****************************************************************************
*                                                                           *
*                   Escolha uma das opções a seguir:                        *    
*                                                                           *
*                           1 - Conta Corrente                              *
*                           2 - Conta Poupança                              *
*                           0 - Sair                                        *
*                                                                           *
*                                                                           *
*****************************************************************************
*****************************************************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Corrente obj_cc = new Corrente("3030-0", "1988", 101);
            Console.WriteLine($"{obj_cc.ToString()}");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            Console.Clear();
            break;
        case "2":
            Corrente obj_cpp = new Corrente("1010-0", "1978", 3);
            Console.WriteLine($"{obj_cpp.ToString()}");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            Console.Clear();
            break;
        case "0":
            Console.WriteLine($"Voce entrou na opcao 0");
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }
} while (opcao != "0");








