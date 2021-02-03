using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Abstract;
using MyGameProject.Entities;

namespace MyGameProject.Concrete
{
    //Micro Service
    public class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager()
        {
        }

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu sisteme eklenmiştir");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız!!!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistem üzerinden silinmiştir");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistem üzerinde güncellenmiştir");
        }
    }
}
