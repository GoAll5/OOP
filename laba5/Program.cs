using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Client> clients = new List<Client>();
                clients.Add(new NotVerifiedClient("Ринат"));
                clients[0] = clients[0].GivePassportId(1);
                clients[0] = clients[0].GiveAddress("Ленинградский");
                clients.Add(new NotVerifiedClient("Максим"));
                clients[1] = clients[1].GivePassportId(2);
                clients[1] = clients[1].GiveAddress("Ленинградский");
                clients.Add(new NotVerifiedClient("Влад"));
                clients[2] = clients[2].GivePassportId(3);
                clients[2] = clients[2].GiveAddress("Ленинградский");
                clients.Add(new NotVerifiedClient("Сергей"));

                Date date1 = new Date(1, 2, 2021);
                Date date2 = new Date(31, 3, 2022);//422
                Date date3 = date2;
                
                Console.WriteLine(date3.Day +"."+ date3.Month +"."+ date3.Year);
                
                BankSystem bankSystem = BankSystem.getInstance(date1);
                bankSystem.AddBank("Сбербанк", 3, 10, 3, 3.5, 4, 50000, date1);
                bankSystem.AddBank("Газпромбанк", 5, 9, 3, 3.5, 4, 100000, date1);

                List<Account> accounts = new List<Account>();
                accounts.Add(new DebitAccount());
                bankSystem.AddAccount("Сбербанк", clients[0], accounts.Last(), 150000); //1

                accounts.Add(new CreditAccount());

                bankSystem.AddAccount("Сбербанк", clients[1], accounts.Last(), 200000); //2

                accounts.Add(new CreditAccount());
                bankSystem.AddAccount("Газпромбанк", clients[1], accounts.Last(), 250000); //3

                accounts.Add(new DebitAccount());
                bankSystem.AddAccount("Газпромбанк", clients[2], accounts.Last(), 300000);//4

                accounts.Add(new CreditAccount());
                bankSystem.AddAccount("Газпромбанк", clients[3], accounts.Last(), 350000); //5

                accounts.Add(new DebitAccount());
                bankSystem.AddAccount("Газпромбанк", clients[3], accounts.Last(), 400000); //6

                accounts.Add(new DebitAccount());
                bankSystem.AddAccount("Сбербанк", clients[3], accounts.Last(), 450000);//7

                bankSystem.Withdrawal(clients[0].Accounts[0].Id, 100000);
                bankSystem.Transfer(clients[0].Accounts[0].Id, clients[1].Accounts[0].Id, 50000);
                bankSystem.Transfer(clients[3].Accounts[1].Id, clients[1].Accounts[0].Id, 50000);
                bankSystem.CancelOperation(clients[0].Operations[0]);
                bankSystem.CancelOperation(clients[0].Operations[0]);
                bankSystem.TakeDate(date2);
                for(int i = 0; i < accounts.Count; i++)
                {
                    Console.WriteLine(accounts[i].Money);
                }
                Console.WriteLine(clients[0].Accounts[0].Id + " " + clients[0].Accounts[0].Money);
                Console.WriteLine(clients[1].Accounts[0].Id + " " + clients[1].Accounts[0].Money);
                Console.WriteLine(clients[1].Accounts[1].Id + " " + clients[1].Accounts[1].Money);
                Console.WriteLine(clients[2].Accounts[0].Id + " " + clients[2].Accounts[0].Money);
                Console.WriteLine(clients[3].Accounts[0].Id + " " + clients[3].Accounts[0].Money);
                Console.WriteLine(clients[3].Accounts[1].Id + " " + clients[3].Accounts[1].Money);
                Console.WriteLine(clients[3].Accounts[2].Id + " " + clients[3].Accounts[2].Money);
                bankSystem.CancelOperation(clients[0].Operations[0]);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
