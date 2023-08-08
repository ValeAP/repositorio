using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class NormalPlayer:playerFather
    {
        Bet bet;
        public NormalPlayer()
        {
            Name = String.Empty;
            CashBalance = 0;
            bet= new Bet();
            
        }
        public NormalPlayer(string name, int cashBalance)
        {
            Name = name;
            CashBalance = cashBalance;
            Bet = new Bet();
        }
        public NormalPlayer(string name,int cashBalance,string stringBet,int intBet)
        {
            Name = name;
            CashBalance = cashBalance;
            Bet = new Bet(stringBet,intBet);
        }
        public string BetString
        {
            get
            {
                return bet._StringBet;
            }
            set
            {
                bet._StringBet = value;
            }
        }
        public int IntBet
        {
            get
            {
                return bet._IntBet;
            }
            set
            {
                bet._IntBet = value;
                //Bet.IntBet = value;
            }
        }

        public Bet Bet 
        { 
            get 
            { 
                return bet; 
            }
            set 
            { 
                bet = value; 
            } 
        }
    }
}
