using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine("Yeni bir kampanya eklenmiştir : " + campaing.CampaingName );
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine("Kampaya silinmiştir : " + campaing.CampaingName);
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine("Mevcut kampanya güncellenmiştir : " + campaing.CampaingName);
        }
    }
}
