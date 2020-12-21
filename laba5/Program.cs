using System;
using System.Collections.Generic;
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
                //Date date1 = new Date(20, 12, 2020);
                //Date date2 = new Date(1, 1, 2021); 12
                //Date date1 = new Date(22, 1, 2021);
                //Date date2 = new Date(20, 2, 2021); 29
                //Date date1 = new Date(1, 2, 2021);
                //Date date2 = new Date(31, 3, 2021); 57
                //Date date1 = new Date(1, 2, 2021);
                //Date date2 = new Date(31, 3, 2022); 422
                Date date1 = new Date(1, 2, 2021);
                Date date2 = new Date(31, 3, 2022);//422
                Date date3 = date2 - date1;
                Console.WriteLine(date3.InDays());
                Console.WriteLine(date3.Day +"."+ date3.Month +"."+ date3.Year);
                
                BankSystem bankSystem = BankSystem.getInstance(date1);
                bankSystem.AddBank("Сбербанк", 3, 10, 3, 3.5, 4, 50000, date1);
                bankSystem.AddBank("Газпромбанк", 5, 9, 3, 3.5, 4, 100000, date1);
                bankSystem.AddAccount("Сбербанк", clients[0], "DebitAccount", 150000); //1
                bankSystem.AddAccount("Сбербанк", clients[1], "CreditAccount", 200000); //2
                bankSystem.AddAccount("Газпромбанк", clients[1], "DepositAccount", 250000); //3
                bankSystem.AddAccount("Газпромбанк", clients[2], "DebitAccount", 300000);//4
                bankSystem.AddAccount("Газпромбанк", clients[3], "CreditAccount", 350000); //5
                bankSystem.AddAccount("Газпромбанк", clients[3], "DepositAccount", 400000); //6
                bankSystem.AddAccount("Сбербанк", clients[3], "DebitAccount", 450000);//7
                bankSystem.Withdrawal(clients[0].Accounts[0].Id, 100000);
                bankSystem.Transfer(clients[0].Accounts[0].Id, clients[1].Accounts[0].Id, 50000);
                bankSystem.Transfer(clients[3].Accounts[1].Id, clients[1].Accounts[0].Id, 50000);
                bankSystem.CancelOperation(clients[0].Operations[0]);
                bankSystem.CancelOperation(clients[0].Operations[0]);
                bankSystem.TakeDate(date2);
                Console.WriteLine(clients[0].Accounts[0].Id + " " + clients[0].Accounts[0].Money);
                Console.WriteLine(clients[1].Accounts[0].Id + " " + clients[1].Accounts[0].Money);
                Console.WriteLine(clients[1].Accounts[1].Id + " " + clients[1].Accounts[1].Money);
                Console.WriteLine(clients[2].Accounts[0].Id + " " + clients[2].Accounts[0].Money);
                Console.WriteLine(clients[3].Accounts[0].Id + " " + clients[3].Accounts[0].Money);
                Console.WriteLine(clients[3].Accounts[1].Id + " " + clients[3].Accounts[1].Money);
                Console.WriteLine(clients[3].Accounts[2].Id + " " + clients[3].Accounts[2].Money);
                bankSystem.CancelOperation(clients[0].Operations[0]);

                //Math.Round(6/12, 2) 2 знака после запятой
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
