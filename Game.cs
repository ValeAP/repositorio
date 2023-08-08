using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO_MAYOR_MENOR
{
    public class Game
    {
        private HousePlayer house;
        private NormalPlayer normPlayer;
        private DiceContainer container;
        private string betResult;
        
        public Game(HousePlayer house, NormalPlayer normalPlayer, DiceContainer container)
        {
            
            this.house = house;
            this.normPlayer = normalPlayer;
            this.container = container;
            betResult = "";
        }

        public void update()
        {
            if (normPlayer.CashBalance >= normPlayer.IntBet)
            {
                if (normPlayer.BetString == "<7")
                {
                    if (house.CashBalance >= normPlayer.IntBet)
                    {
                        if (container.ResultDiceContainer < 7)
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance + normPlayer.IntBet;
                            house.CashBalance = house.CashBalance - normPlayer.IntBet;
                            betResult = "gano";
                        }
                        else
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance - normPlayer.IntBet;
                            house.CashBalance = house.CashBalance + normPlayer.IntBet;
                            betResult = "perdio";
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} la casa de apuesta ya no tiene dinero para apostar", normPlayer.Name);
                    }
                }
                if (normPlayer.BetString == "=7")
                {
                    if (house.CashBalance >= 2 * normPlayer.IntBet)
                    {

                        if (container.ResultDiceContainer == 7)
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance + 2 * normPlayer.IntBet;
                            house.CashBalance = house.CashBalance - 2 * normPlayer.IntBet;
                            betResult = "gano";
                        }
                        else
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance - normPlayer.IntBet;
                            house.CashBalance = house.CashBalance + normPlayer.IntBet;
                            betResult = "perdio";
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} la casa de apuesta ya no tiene dinero para apostar", normPlayer.Name);
                    }
                }
                if (normPlayer.BetString == ">7")
                {
                    if (house.CashBalance >= normPlayer.IntBet)
                    {
                        if (container.ResultDiceContainer > 7)
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance + normPlayer.IntBet;
                            house.CashBalance = house.CashBalance - normPlayer.IntBet;
                            betResult = "gano";
                        }
                        else
                        {
                            normPlayer.CashBalance = normPlayer.CashBalance - normPlayer.IntBet;
                            house.CashBalance = house.CashBalance + normPlayer.IntBet;
                            betResult = "perdio";
                        }
                    }
                    else
                    {
                        betResult=normPlayer.Name+" la casa de apuesta ya no tiene dinero para apostar";
                    }

                }
            }
            else
            {
                betResult= normPlayer.Name+" no tiene saldo suficiente para apostar";
            }

        }
        public void registerPlayer(string name, int cashBalance)
        {
            normPlayer.Name = name;
            normPlayer.CashBalance = cashBalance;
            //normPlayer.Bet = new Bet();
        }
        public void registerHouse(string name, int cashBalance)
        {
            house.Name = name;
            house.CashBalance = cashBalance;
        }
        public void registerBetPlayer(int intBet,string betString)
        {
            //normPlayer.Bet = new Bet();
            normPlayer.IntBet=intBet;
            normPlayer.BetString = betString;
        }
        public void throwContainer()
        {
            container.throwDiceContainer();
            update();

        }
        public string returnDataGames()
        {
            string dataGames;
            dataGames = "Saldo del jugador " + normPlayer.Name + ":" + normPlayer.CashBalance.ToString() + "  Saldo de la casa " + house.Name + ":" + house.CashBalance.ToString(); 
            return dataGames;

        }
        public string getBetResult()
        {
            //string result=String.Empty;
            //if(normPlayer.IntBet>=normPlayer.CashBalance)
            //{
            //    result = normPlayer.Name + " usted " + betResult + " " + normPlayer.IntBet.ToString() + "Bs";
            //    if (normPlayer.BetString == "=7" && betResult == "gano")
            //    {
            //        result = normPlayer.Name + " usted " + betResult + " " + (2 * normPlayer.IntBet).ToString() + "Bs";
            //    }
            //    return result;
            //}

            //if (normPlayer.IntBet < normPlayer.CashBalance)
            //{
            //    result = normPlayer.Name + " usted no tiene"  + normPlayer.IntBet.ToString() + "Bs";
            //    //if (normPlayer.BetString == "=7" && betResult == "gano")
            //    //{
            //    //    result = normPlayer.Name + " usted no tiene " + betResult + " " + (2 * normPlayer.IntBet).ToString() + "Bs";
            //    //}
            //    return result;
            //}
            //return result;
            string result = String.Empty;

            
            if (normPlayer.BetString == "=7" && betResult == "gano")
            {
                result = normPlayer.Name + " usted " + betResult + " " + (2 * normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            if (normPlayer.BetString == "<7" && betResult == "gano")
            {
                result = normPlayer.Name + " usted " + betResult + " " + ( normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            if (normPlayer.BetString == ">7" && betResult == "gano")
            {
                result = normPlayer.Name + " usted " + betResult + " " + ( normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            if (normPlayer.BetString == "=7" && betResult == "perdio")
            {
                result = normPlayer.Name + " usted " + betResult + " " + ( normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            if (normPlayer.BetString == "<7" && betResult == "perdio")
            {
                result = normPlayer.Name + " usted " + betResult + " " + (normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            if (normPlayer.BetString == ">7" && betResult == "perdio")
            {
                result = normPlayer.Name + " usted " + betResult + " " + (normPlayer.IntBet).ToString() + "Bs";
                return result;
            }
            
            return betResult;
        }
        public void restart()
        {
            normPlayer.Name = string.Empty;
            normPlayer.CashBalance = 0;
            normPlayer.IntBet = 0;
            normPlayer.BetString = string.Empty;
            house.Name = string.Empty;
            house.CashBalance = 0;
            
        }
        public int getResultContainer()
        {

            return container.ResultDiceContainer;
        }
    }
}

