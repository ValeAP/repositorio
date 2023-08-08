using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class GameController
    {
        private Game game1;
        public GameController(Game game1)
        {
            this.game1 = game1;
        }
        public void registerBetPlayer(int intBet,string betString)
        {
            game1.registerBetPlayer(intBet,betString);
        }
        public void throwContainer()
        {
            game1.throwContainer();
        }
        public string returnDataGames()
        {
            return game1.returnDataGames();

        }
        public string getBetResult()
        {
            return game1.getBetResult();
        }
        public int getResultContainer()
        {

            return game1.getResultContainer();
        }

    }
}
