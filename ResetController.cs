using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class ResetController
    {
        private Game game1;
        //private ConfigView configView2;
        public ResetController(Game game1/*,ConfigView configView2*/)
        {
            this.game1 = game1;
            //this.configView2= configView2;
            
        }
        public void restart()
        {

            game1.restart();


            //configView2.registerPlayer();
            //configView2.registerHouse();
            //while (true)
            //{
            //    configView2.GameView.registerBetPlayer();
            //    configView2.GameView.throwContainer();

            //}

            //LO NUEVO
            string resp = String.Empty;
            Console.Clear();
            ConfigView configView=new ConfigView();
            configView.registerPlayer();
            configView.registerHouse();
            while(true)
            {
                Console.WriteLine("Desea continuar juagando?s/n");
                resp = Console.ReadLine();
                if (resp == "n")
                {
                    Environment.Exit(0);
                }
                configView.GameView.registerBetPlayer();
                configView.GameView.throwContainer();
            }
            



        }


    }
}
