using System;

namespace ContaCorrente.ConsoleApp.Entidades;

//Centralização de atributos e metodos em comum
public class Conta
{

    public int id;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;


    public void Sacar(decimal valorSaque)
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

    public void Deposito(decimal valorDeposito)
    {
        saldo += valorDeposito;

        Console.WriteLine($"> O deposito de R$ {valorDeposito}, foi realizado com sucesso!");
        Console.ReadLine();
    }

    public void Transferir(decimal valorTransferencia, Conta contaDestino)
    {
        
        decimal limiteSaque = saldo + limiteDebito;        

        if (valorTransferencia > limiteSaque)
        {
            Console.WriteLine("> Não é possível concluir sua tranferencia! Valor acima do saldo.");
            Console.ReadLine();
            return;
        } 

        this.Sacar(valorTransferencia);

        contaDestino.Deposito(valorTransferencia);

    }

    public void VisualizarSaldo()
    {
        Console.WriteLine($"> O saldo da conta é: R$ {saldo}");
        Console.ReadLine();
    }
}
