using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Database;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();

            user1.Id = 1; user1.TcNo = "123456789"; user1.FirstName = "Hikmet"; user1.LastName = "Gürbüz";user1.BirthYear = new DateTime(1996 / 02 / 11);
            user2.Id = 2; user2.TcNo = "234567891"; user2.FirstName = "Gizem"; user2.LastName = "Candansayar"; user2.BirthYear = new DateTime(1995 / 09 / 12);
            user3.Id = 3; user3.TcNo = "345678912"; user3.FirstName = "Şule Nur"; user3.LastName = "Altun"; user3.BirthYear = new DateTime(1997 / 06 / 24);
            user4.Id = 4; user4.TcNo = "456789123"; user4.FirstName = "Umut"; user4.LastName = "Şahin"; user4.BirthYear = new DateTime(1997 / 10 / 31);

            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Save(user1);

            Game game1 = new Game();
            Game game2 = new Game();
            Game game3 = new Game();
            Game game4 = new Game();

            game1.Id = 1; game1.GameName = "Grand Thief Auto: San Andreas"; game1.GamePrice = 45;
            game2.Id = 2; game2.GameName = "Battlefield Bad Company 2"; game2.GamePrice = 75;
            game3.Id = 3; game3.GameName = "The Elder Scrolls: Skyrim"; game3.GamePrice = 130;
            game4.Id = 4; game4.GameName = "Cities Skylines"; game4.GamePrice = 60;

            GameManager gameManager = new GameManager();
            gameManager.Add(game3);

            Campaign campaign1 = new Campaign();
            Campaign campaign2 = new Campaign();
            Campaign campaign3 = new Campaign();

            campaign1.Id = 1; campaign1.CampaignName = "Cadılar Bayramı İndirimleri"; campaign1.Discount = 20;
            campaign2.Id = 2; campaign2.CampaignName = "Muhteşem Kış İndirimleri"; campaign2.Discount = 35;
            campaign3.Id = 3; campaign3.CampaignName = "Sıcak Yaz İndirimleri"; campaign3.Discount = 40;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1, game3);

            Sales sales1 = new Sales();

            sales1.Id = 1;
            sales1.SaleDate = DateTime.Now;

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(user1, game3, campaign1, sales1);

            salesManager.Return(user1, game3, campaign1, sales1);

            ILoggerService fileloggerService = new FileLogger();
            ILoggerService databaseloggerService = new DatabaseLogger();
            fileloggerService.Log();
            //loglama işleminde birden çok loglama yapmak istersek list kullanarak foreach içinde döndürerek yapılabilir.

            Console.ReadLine();
        }
    }
}
