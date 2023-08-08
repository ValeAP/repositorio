using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class HousePlayer:playerFather
    {
        public HousePlayer()
        {
            Name = String.Empty;
            CashBalance = 0;
        }
        public HousePlayer(string name, int cashBalance)
        {
            Name = name;
            CashBalance = cashBalance;
            
        }
    }
}
