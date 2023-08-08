using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class ConfigController
    {
        private Game game1;
        private HousePlayer house;
        private NormalPlayer normal;
        private DiceContainer container;

        public Game Game1 
        {
            get
            {
                return game1;
            }
            set
            {
                game1= value;
            }
        }
        //cuando ya no tiene saldo para apostar ya no deberia decir juanito gano tantos
        public ConfigController()
        {
            house=new HousePlayer();
            normal=new NormalPlayer();
            container=new DiceContainer();
            Game1 = new Game(house, normal, container);

        }
        public void registerPlayer(string name, int cashBalance)
        {
            Game1.registerPlayer(name, cashBalance);
        }
        public void registerHouse(string name, int cashBalance)
        {
            Game1.registerHouse(name, cashBalance);
        }
    }
}
