using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class ConfigView
    {
        private ConfigController configController;
        private GameView gameView;
        //private ConfigView configView2;

        //public ConfigView CONFIGVIEW
        //{
        //    get
        //    {
        //        return configView2;
        //    }
        //    set
        //    {
        //        configView2 = value;
        //    }
        //}


        public ConfigView()
        {
            configController = new ConfigController();
            Game game1 = configController.Game1;
            GameView = new GameView(game1/*,configView2*/);
        }
        

        public GameView GameView 
        { 
            get
            {
                return gameView;
            }
            set
            {
                gameView=value;
            }
        }

        

        public void registerPlayer()
        {
            string name;
            string cashBalance;
            
            Console.WriteLine("Porfavor digame su nombre");
            name=Console.ReadLine();
            Console.WriteLine("Porfavor digame su saldo");
            cashBalance = Console.ReadLine();
            

            configController.registerPlayer(name, int.Parse(cashBalance));
        }
        public void registerHouse()
        {
            string name;
            string cashBalanceString;
            int cashBalance;
            Console.WriteLine("Porfavor digame el nombre de la casa de apuestas");
            name = Console.ReadLine();
            Console.WriteLine("Porfavor digame el saldo de la casa de apuestas");
            cashBalanceString = Console.ReadLine();
            cashBalance = int.Parse(cashBalanceString);
            configController.registerHouse(name, cashBalance);
        }
        


    }
}
