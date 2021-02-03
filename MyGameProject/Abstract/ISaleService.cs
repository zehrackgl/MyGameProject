using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
   public interface ISaleService
    {
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
