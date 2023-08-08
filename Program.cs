using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DiceContainer contenedor = new DiceContainer();
            //contenedor.throwDiceContainer();
            //Console.WriteLine(contenedor.ResultDiceContainer);
            //Console.ReadKey();
            //int result,result2;
            //int[] sides = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            //    sides[i] = i + 1;
            //}
            //Random rand = new Random();
            //result = sides[rand.Next(0, 6)];
            //result2 = sides[rand.Next(0, 6)];
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //NormalPlayer norm = new NormalPlayer();
            //norm.CashBalance = 15;
            //HousePlayer house = new HousePlayer();
            //house.CashBalance = 20;
            //Console.WriteLine(norm.CashBalance);
            //Console.WriteLine(house.CashBalance);
            //Console.ReadLine();


            //VALERY
            //HousePlayer h1 = new HousePlayer("house", 100);
            //NormalPlayer p1 = new NormalPlayer("pepito", 200, "=7",20);
            //DiceContainer dc1 = new DiceContainer();
            //Game g1=new Game(h1, p1, dc1);

            //Console.WriteLine(h1.CashBalance);
            //Console.WriteLine(p1.CashBalance);

            //dc1.ResultDiceContainer =7 ;
            //g1.update();
            //Console.WriteLine(dc1.ResultDiceContainer);
            //Console.WriteLine(h1.CashBalance);
            //Console.WriteLine(p1.CashBalance);


            //Console.ReadLine();


            
            string resp = String.Empty;
            ConfigView configView = new ConfigView();

            
            configView.registerPlayer();
            configView.registerHouse();
            while(true)
            {
                
         
                configView.GameView.registerBetPlayer();
                configView.GameView.throwContainer();
                Console.WriteLine("Desea seguir juagando?s/N");
                resp=Console.ReadLine();
                if(resp=="N")
                {
                    Environment.Exit(0);
                }

            }
            

            



        }
    }
}
