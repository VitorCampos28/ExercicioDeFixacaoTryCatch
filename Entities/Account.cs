using System;
using System.Collections.Generic;
using System.Text;
using ExercicioDeFixacaoTryCatch.Entities.Exceptions;

namespace ExercicioDeFixacaoTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimite { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimite)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimite = withdrawLimite;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimite)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }

            Balance -= amount; 
        }

        public override string ToString()
        {
            return "New balance: " + Balance;
        }
    }
}
