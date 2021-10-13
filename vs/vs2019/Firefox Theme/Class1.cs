using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firefox_Theme
{
    class Class1
    {
        public int TEST = 0;

        private enum PLAYER_STATE
        {
            FREE, ATTACK, RUN, HIT, DEATH, STUN        
        }

        int addNumbers(int number, int number_2)
        {
            return number + number_2;
        }

        void playerStates()
        {
            PLAYER_STATE playerState = PLAYER_STATE.ATTACK;

            switch (playerState)
            {
                case PLAYER_STATE.FREE: Console.WriteLine("Free"); break;
                case PLAYER_STATE.RUN: Console.WriteLine("Run"); break;
                case PLAYER_STATE.ATTACK: Console.WriteLine("Attack"); break;
                case PLAYER_STATE.HIT: Console.WriteLine("Hit"); break;
                case PLAYER_STATE.STUN: Console.WriteLine("Stun"); break;
                case PLAYER_STATE.DEATH: Console.WriteLine("Death"); break;

                default:
                    break;
            }
        }
    }
}
