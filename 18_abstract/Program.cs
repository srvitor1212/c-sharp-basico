using System;
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1001, "Alex", 500.0); //Não deixa instânciar pois é abstract
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            // Exemplo de uso de classe abstrata
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double soma = 0;
            foreach (Account acc in list)
            {
                soma += acc.Balance;
            };
            System.Console.WriteLine("Total: " + soma.ToString("F2", CultureInfo.InvariantCulture ));


            System.Console.WriteLine("Saque usando a lista:");
            foreach (Account acc in list)
            {
                acc.Withdraw(10);
            };
            foreach (Account acc in list)
            {
                System.Console.WriteLine("Conta: " + acc.Number + ", Nome: " + acc.Holder + ", saldo: " + acc.Balance);;
            };
        }
    }
}
