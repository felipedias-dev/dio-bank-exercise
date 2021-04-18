using System;

namespace Bank.Challenge
{
  public class Conta
  {
    private TipoConta TipoConta { get; set; }
    private double Saldo { get; set; }
    private double Limite { get; set; }
    private string Titular { get; set; }
    public Conta(TipoConta tipoConta, double saldo, double limite, string titular)
    {
      this.TipoConta = tipoConta;
      this.Saldo = saldo;
      this.Limite = limite;
      this.Titular = titular;
    }

    public bool Sacar(double valorSaque)
    {
      if (this.Saldo - valorSaque < -this.Limite)
      {
        Console.WriteLine("Saldo insuficiente!");

        return false;
      }

      this.Saldo -= valorSaque;

      Console.WriteLine("Saldo em conta: R$ {0:0.00}", this.Saldo);

      return true;
    }

    public void Depositar(double valorDeposito)
    {
      this.Saldo += valorDeposito;

      Console.WriteLine("Saldo em conta: R$ {0:0.00}", this.Saldo);
    }

    public bool Transferir(double valorTransferencia, Conta contaDestino)
    {
      if (this.Saldo - valorTransferencia < -this.Limite)
      {
        Console.WriteLine("Saldo insuficiente!");
        Console.WriteLine("Transferência não efetuada!");

        return false;
      }

      this.Sacar(valorTransferencia);
      contaDestino.Depositar(valorTransferencia);

      Console.WriteLine("Transferência efetuada com sucesso!");

      return true;
    }

    public override string ToString()
    {
      string formatado = "";
      formatado += "Tipo " + this.TipoConta + " | ";
      formatado += "Titular " + this.Titular + " | ";
      formatado += "Saldo " + this.Saldo + " | ";
      formatado += "Limite " + this.Limite;

      return formatado;
    }
  }
}
