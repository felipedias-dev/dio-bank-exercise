using System;
using System.Collections.Generic;

namespace Bank.Challenge
{
  class Program
  {
    static List<Conta> listaContas = new List<Conta>;
    static void Main(string[] args)
    {
      string opcao = "s";
      do
      {
        Console.WriteLine();
        Console.WriteLine("Selecione a opção desejada:");
        Console.WriteLine("(1) Cadastrar conta");
        Console.WriteLine("(2) Selecionar conta");
        Console.WriteLine("(3) Depositar");
        Console.WriteLine("(4) Sacar");
        Console.WriteLine("(5) Transferir");
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
            Console.WriteLine("Conta cadastrada.");
            break;

          case "2":
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Atendimento encerrado.");
            break;

          case "3":
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Atendimento encerrado.");
            break;

          case "4":
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Atendimento encerrado.");
            break;

          case "5":
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Atendimento encerrado.");
            break;

          default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
        }
      } while (opcao.ToUpper() != "S");
      Console.WriteLine("Hello World!");
      Conta conta = new Conta(tipoConta: TipoConta.PessoaFisica, titular: "Felipe", saldo: 100, limite: 200);
      // conta.Transferir(400);
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
    }
  }
}
