using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class GameView
    {
        private GameController gameController;
        private ResetView resetView;
        //private ConfigView configView2;
        
        private Game game1;
        public ResetView ResetView
        {
            get
            {
                return resetView;
            }
            set
            {
                resetView = value;
            }
        }

        public GameView(Game game1/*,ConfigView configView2*/)
        {
            gameController = new GameController(game1);
            this.game1= game1;
            //this.configView2 = configView2;
            
        }

        public void registerBetPlayer()
        {
            string intBet;
            string betString;
            Console.WriteLine("Porfavor digame el dinero que apostara");
            intBet = Console.ReadLine();
            Console.WriteLine("Porfavor digame a que numero le apostara");
            betString = Console.ReadLine();
            gameController.registerBetPlayer(int.Parse(intBet), betString);
        }
        public void showDataGames()
        {
            string dataGames;
            dataGames = gameController.returnDataGames();
            Console.WriteLine(dataGames);
            
        }
        public void getBetResult()
        {
            string betResult;
            betResult = gameController.getBetResult();
            Console.WriteLine(betResult);
        }
        public void getResultContainer()
        {

            Console.WriteLine("El resultado del contenedor fue:{0}",gameController.getResultContainer());
        }
        public void throwContainer()
        {
            string resp;
            Console.WriteLine("Desea confirmar la apuesta y tirar el cubilete? s/n");
            resp=Console.ReadLine();
            if(resp=="s")
            {
                gameController.throwContainer();

                //Lo de abajo solo se muestra si arriba hubo exito el de arriba tendra que trabajar
                //con un try catch
                getBetResult();
                getResultContainer();


                showDataGames();

            }
            else
            {
                Console.WriteLine("No se tiro el cubilete");
                Console.WriteLine("Desea reiniciar todo el juego? s/n?");
                resp = Console.ReadLine();
                if (resp == "s")
                {
                    ResetView resetView = new ResetView(game1/*,configView2*/);
                    
                    resetView.restart();

                }
                else
                {
                    Console.WriteLine("Desea salir del juego?s/n");
                    resp = Console.ReadLine();
                    if(resp=="s")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        throwContainer();
                    }


                }


            }

            
        }


    }
}
