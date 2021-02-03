using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("İndirim uygulanmıştır : " + sale.SaleName);
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("İndirim hakkınız bitmiştir : " + sale.SaleName);
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("İndirim miktarınız güncellenmiştir : " + sale.SaleName);
        }
    }
}
