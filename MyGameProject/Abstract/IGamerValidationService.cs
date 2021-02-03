using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entities;

namespace MyGameProject.Abstract
{
    public interface IGamerValidationService
    {
        bool Validate(Gamer gamer);

    }
}
