using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Este es solo un comentario 
namespace JUEGO_MAYOR_MENOR
{
    public class Bet
    {
        private string stringBet;
        private int intBet;
        public Bet()
        {
            stringBet = String.Empty;
            intBet= 0;
        }
        public Bet(string stringBet, int intBet)
        {
            this.stringBet = stringBet;
            this.intBet = intBet;
               
        }
        public string _StringBet
        {
            get { return stringBet; }
            set { stringBet = value; }
        }
        public int _IntBet
        {
            get { return intBet; }
            set { intBet = value; }
        }
    }
}
