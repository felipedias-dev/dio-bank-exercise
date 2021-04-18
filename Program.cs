using System;
using System.Collections.Generic;

namespace Bank.Challenge
{
  class Program
  {
    static List<Conta> listaContas = new List<Conta>();
    static Conta contaAtual;
    static void Main(string[] args)
    {
      string opcao = "s";
      do
      {
        Console.WriteLine();
        Console.WriteLine("Selecione a opcao desejada:");
        Console.WriteLine("(S) Sair");
        Console.WriteLine("(1) Cadastrar conta");
        Console.WriteLine("(2) Listar contas");
        Console.WriteLine("(3) Selecionar conta");
        Console.WriteLine("(4) Depositar");
        Console.WriteLine("(5) Sacar");
        Console.WriteLine("(6) Transferir");
        Console.WriteLine();

        opcao = Console.ReadLine();
        Console.WriteLine();

        switch (opcao)
        {
          case "s":
          case "S":
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Atendimento encerrado.");
            break;

          case "1":
            CadastrarConta();
            break;

          case "2":
            ListarContas();
            break;

          case "3":
            SelecionarConta();
            break;

          case "4":
            Depositar();
            break;

          case "5":
            Sacar();
            break;

          case "6":
            Transferir();
            break;

          default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
        }
      } while (opcao.ToUpper() != "S");
    }

    private static void Transferir()
    {
      if (listaContas.Count < 2)
      {
        Console.WriteLine("Não há contas suficientes cadastradas!");
        return;
      }

      Console.WriteLine("Conta de origem: {0}", contaAtual);

      ListarContas();

      Console.Write("Informe o numero da conta de destino: ");
      int numeroConta = int.Parse(Console.ReadLine());

      Console.Write("Informe o valor da tranferencia: ");
      double valorDeposito = double.Parse(Console.ReadLine());

      contaAtual.Transferir(valorDeposito, listaContas[numeroConta]);
    }

    private static void Depositar()
    {
      if (listaContas.Count <= 0)
      {
        Console.WriteLine("Ainda não há contas cadastradas!");
        return;
      }

      Console.Write("Informe o valor do deposito: ");
      double valorDeposito = double.Parse(Console.ReadLine());
      contaAtual.Depositar(valorDeposito);
    }

    private static void Sacar()
    {
      if (listaContas.Count <= 0)
      {
        Console.WriteLine("Ainda não há contas cadastradas!");
        return;
      }

      Console.Write("Informe o valor do saque: ");
      double valorSaque = double.Parse(Console.ReadLine());
      contaAtual.Sacar(valorSaque);
    }

    private static void ListarContas()
    {
      if (listaContas.Count <= 0)
      {
        Console.WriteLine("Ainda não há contas cadastradas!");
        return;
      }

      Console.WriteLine();
      Console.WriteLine("Constas disponiveis:");
      for (int indiceConta = 0; indiceConta < listaContas.Count; indiceConta++)
        {
          Console.WriteLine("({0}) {1}", indiceConta, listaContas[indiceConta]);
        }
      Console.WriteLine();
    }

    private static void SelecionarConta()
    {
      if (listaContas.Count <= 0)
      {
        Console.WriteLine("Ainda não há contas cadastradas!");
        return;
      }

      int opcao;

      do
      {
        Console.WriteLine();
        Console.WriteLine("Selecione a conta desejada:");
        for (int indiceConta = 0; indiceConta < listaContas.Count; indiceConta++)
        {
          Console.WriteLine("({0}) {1}", indiceConta, listaContas[indiceConta]);
        }
        Console.WriteLine();

        opcao = int.Parse(Console.ReadLine());
        Console.WriteLine();
      } while (opcao >= listaContas.Count || opcao < 0);

      contaAtual = listaContas[opcao];
    }

    private static void CadastrarConta()
    {
      Console.Write("Informe o tipo da conta: ");
      int entradaTipoConta = int.Parse(Console.ReadLine());

      Console.Write("Informe o nome do titular: ");
      string entradaTitular = Console.ReadLine();

      Console.Write("Informe o saldo: ");
      double entradaSaldo = double.Parse(Console.ReadLine());

      Console.Write("Informe o limite: ");
      double entradaLimite = double.Parse(Console.ReadLine());

      Conta novaConta = new Conta(
        tipoConta: (TipoConta) entradaTipoConta,
        saldo: entradaSaldo,
        limite: entradaLimite,
        titular: entradaTitular
      );

      listaContas.Add(novaConta);
      contaAtual = novaConta;
    }
  }
}
