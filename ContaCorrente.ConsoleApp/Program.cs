/*
Uma conta corrente é composta por diversos atributos essenciais para sua operação. Ela possui um número
de identificação único, um saldo disponível e um limite de débito estabelecido.
*/

// conta
using ContaCorrente.ConsoleApp.Entidades;


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
    Console.WriteLine("║ 3 - CONSULTA DE SALDO      ║");
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

        Conta.Sacar(valorSaque);

    }
    else if (opcaoMenu == "2")
    {

        Console.Write("> Digite o valor do deposito: R$ ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        Conta.Deposito(valorDeposito);

    }
    else if (opcaoMenu == "3")
    {
        Conta.VisualizarSaldo();
    }
}