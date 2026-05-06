/*
Uma conta corrente é composta por diversos atributos essenciais para sua operação. Ela possui um número
de identificação único, um saldo disponível e um limite de débito estabelecido.
*/

// conta
using ContaCorrente.ConsoleApp.Entidades;

Conta contaRailan = new Conta();
contaRailan.id = 1;
contaRailan.titular = "Railan";
contaRailan.saldo = 1200;
contaRailan.limiteDebito = 800;

Conta contaTeste = new Conta();
contaTeste.id = 1;
contaTeste.titular = "Railan";
contaTeste.saldo = 4000;
contaTeste.limiteDebito = 1000;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("╔════════════════════════════╗");
    Console.WriteLine("║       CONTA CORRENTE       ║");
    Console.WriteLine("╚════════════════════════════╝");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("║ 1 - SAQUE                  ║");
    Console.WriteLine("║ 2 - DEPÓSITO               ║");
    Console.WriteLine("║ 3 - TRANSFERIR             ║");
    Console.WriteLine("║ 4 - CONSULTA DE SALDO      ║");
    Console.WriteLine("║ S - SAIR                   ║");
    Console.WriteLine("╚════════════════════════════╝");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine();
    Console.ResetColor();

    if (opcaoMenu?.ToUpper() == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.Write(" >Digite o valor que desaja sacar? R$ ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        contaRailan.Sacar(valorSaque);

    }
    else if (opcaoMenu == "2")
    {

        Console.Write("> Digite o valor do deposito: R$ ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaRailan.Deposito(valorDeposito);

    }
    else if (opcaoMenu =="3")
    {

        Console.Write("> Digite o valor que deseja tranferir: R$ ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        contaRailan.Transferir(valorTransferencia, contaTeste);

    }
    else if (opcaoMenu == "4")
    {
        contaRailan.VisualizarSaldo();
    }
}