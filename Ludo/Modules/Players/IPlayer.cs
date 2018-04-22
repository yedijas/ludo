using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Modules.Players
{
    public interface IPlayer
    {
        bool IsHuman();
        string GetName();
        int DoDiceRoll();

    }
}
