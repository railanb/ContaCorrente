using System;

namespace ContaCorrente.ConsoleApp.Entidades;

//Centralização de atributos e metodos em comum
public static class Conta
{

    public static int id = 1;
    public static decimal saldo = 1200;
    public static decimal limiteDebito = 800;


    public static void Sacar(decimal valorSaque)
    {
        decimal limiteSaque = saldo + limiteDebito;        
        
        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("> Não é possível concluir seu saque! Valor acima do saldo.");
            Console.ReadLine();
            return;
        } 

        saldo -= valorSaque;

        Console.WriteLine($"> O saque  de R$ {valorSaque}, foi realizado com sucesso!");
        Console.ReadLine();
    }

    public static void Deposito(decimal valorDeposito)
    {
        saldo += valorDeposito;

        Console.WriteLine($"> O deposito de R$ {valorDeposito}, foi realizado com sucesso!");
        Console.ReadLine();
    }

    public static void VisualizarSaldo()
    {
        Console.WriteLine($"> O saldo da conta é: R$ {saldo}");
        Console.ReadLine();
    }
}
