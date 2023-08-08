using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class DiceContainer
    {
        private Dice dice1;
        private Dice dice2;
        private int resultDiceContainer;
        public DiceContainer()
        {
            dice1 = new Dice();
            dice2 = new Dice();

        }
        public int ResultDiceContainer
        {
            get
            {
                return resultDiceContainer;
            }
            set
            {
                resultDiceContainer = value;
            }
        }
        public void throwDiceContainer()
        {
            Random rand = new Random();
            dice1.Result = rand.Next(1, 7);
            dice2.Result = rand.Next(1, 7);
            
            resultDiceContainer = dice1.Result + dice2.Result;
            //Console.WriteLine("El resultado del cubilede de dados es {0}",ResultDiceContainer);
        }
    }



}
