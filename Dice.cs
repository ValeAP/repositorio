using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class Dice
    {

        private int result;

        public Dice()
        {
            result = 0;

        }


        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

    }






}
