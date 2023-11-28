using System;
using System.Globalization;
using Program.Entities;
using Program.Entities.Exception;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
          try
          {
             // entrada de dados 

           Console.WriteLine("Enter account data");

           Console.Write("Number: ");
           int number = int.Parse(Console.ReadLine());

           Console.Write("Holder: ");
           string holder = Console.ReadLine();

           Console.Write("Initial balance: ");
           double inicialBalance = double.Parse(Console.ReadLine());

           Console.Write("Withdraw limit: ");
           double withdrawLimit = double.Parse(Console.ReadLine());
           
           // processando dados  

           Account account = new Account(number, holder, inicialBalance, withdrawLimit); 

             // funcionalidade de sacar o dinheiro

                Console.WriteLine(); 

                Console.Write("Enter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine());
                account.Withdrawlimit(amountWithdraw);

            // saida de dados
            Console.WriteLine(account);
          }
          catch (DomainException e)
          {
            Console.WriteLine($" Withdraw error: {e.Message}");
          }
          catch (FormatException e)
          {
            Console.WriteLine($"Format error: {e.Message}");
          }
          catch (Exception e)
          {
            Console.WriteLine($"Unexpected error: {e.Message}");
          }
        }
   }
}

