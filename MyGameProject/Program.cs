using System;
using MyGameProject.Concrete;
using MyGameProject.Entities;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            //gamerManager.Add(new Gamer { FirstName= "Zehra",LastName = "Açıkgül", GamerId = 123456, 
            //    IdentityNumber = 12345678910, BirthYear = 2001 });

            Gamer gamer = new Gamer();
            gamer.FirstName = "Zehra";
            gamer.LastName = "Açıkgül";
            gamer.IdentityNumber = 12345678910;
            gamer.GamerId = 1;
            gamer.BirthYear = 2001;

            Campaign campaign = new Campaign();
            campaign.CampaingId = 1;
            campaign.CampaingName = "Yeni kayıt";
            campaign.CampaingDetails = "Sisteme ilk defa kayıt olanlara uygulanır";

            Sale sale = new Sale();
            sale.SaleId = 2;
            sale.SaleName = "Satış";
            sale.SaleDetails = "Satış hakkında bilgileri yazdırır";

            GamerManager gamerManager = new GamerManager();
            GamerValidationManager gamerValidationManager = new GamerValidationManager();

            Console.WriteLine(gamer.FirstName + " / "  + gamer.LastName + " / " + gamer.IdentityNumber + " / " + gamer.BirthYear + " / " + gamer.GamerId );

            Console.WriteLine(campaign.CampaingId + "  / " + campaign.CampaingName + " / " + campaign.CampaingDetails);

            Console.WriteLine(sale.SaleId + " / " + sale.SaleName + " / " + sale.SaleDetails);








        }
    }
}
