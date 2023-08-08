using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class ResetView
    {
        private ResetController resetController;
        
        public ResetView(Game game1/*,ConfigView configView2*/)
        {
            resetController = new ResetController(game1/*,configView2*/);
            
            
        }
        public void restart()
        {
            Console.WriteLine("Se reiniciara todo el juego");
                resetController.restart();
                //configView.registerPlayer();
                //configView.registerHouse();
                //while (true)
                //{
                //    configView.GameView.registerBetPlayer();
                //    configView.GameView.throwContainer();
                //}
            
        }

    }
}
