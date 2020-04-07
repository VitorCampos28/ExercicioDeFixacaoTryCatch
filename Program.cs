using ExercicioDeFixacaoTryCatch.Entities;
using ExercicioDeFixacaoTryCatch.Entities.Exceptions;
using System;

namespace ExercicioDeFixacaoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int numberC = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Inicial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limite: ");
                double wLimite = double.Parse(Console.ReadLine());
                Account account = new Account(numberC , holder , balance , wLimite);


                Console.WriteLine();
                Console.Write("Enter amount for Withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.Withdraw(withdraw);

                Console.WriteLine(account);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("format error: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
