// See https://aka.ms/new-console-template for more information

using projeto_paralelo;
/*
Conta obj_conta = new Conta("7","8898");

//obj_conta.numero = "7800-8";
//obj_conta.setNumero("7800-8");
//obj_conta.agencia = "8898";
//obj_conta.saldo = 1000;
//obj_conta.setSaldo(1000);

Console.WriteLine($"Agencia: {obj_conta.agencia}");
Console.WriteLine($"Numero: {obj_conta.numero}");
Console.WriteLine($"Saldo: {obj_conta.getSaldo()}");
*/

Corrente obj_cc = new Corrente("3030-0","1988",101);
/*
string ret;
ret = obj_cc.ToString();
Console.WriteLine($"{ret}");
*/
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"******************************************************");
//obj_cc.Depositar(100);
Console.WriteLine($"{obj_cc.Depositar(100)}");
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"******************************************************");
Console.WriteLine($"{obj_cc.Sacar(300)}");
Console.WriteLine($"{obj_cc.ToString()}");






