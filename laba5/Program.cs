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

            Console.WriteLine(date3.Day + "." + date3.Month + "." + date3.Year);

            BankSystem bankSystem = BankSystem.getInstance(date1);
            bankSystem.AddBank("Сбербанк", 3, 10, 3, 3.5, 4, 50000, date1);
            bankSystem.AddBank("Газпромбанк", 5, 9, 3, 3.5, 4, 100000, date1);

            bankSystem.AddDebitAccount("Сбербанк", clients[0], 150000); //1

            bankSystem.AddCreditAccount("Сбербанк", clients[1], 200000); //2


            bankSystem.AddDepositAccount("Газпромбанк", clients[1], 250000); //3


            bankSystem.AddDebitAccount("Газпромбанк", clients[2], 300000);//4

            bankSystem.AddCreditAccount("Газпромбанк", clients[3], 350000); //5

            bankSystem.AddDebitAccount("Газпромбанк", clients[3], 400000); //6

            bankSystem.AddDepositAccount("Сбербанк", clients[3], 450000);//7

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


        }
    }
}
// изменяемый аккаунт, тайп(сделать три отдельных метода у банка), статик много у одиночки, трай кетч