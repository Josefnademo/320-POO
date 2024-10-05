//Auteur : JMY
//Date   : 21.1.2020 
//Lieu   : ETML
//Descr. : Missile
using System;

namespace SpicyInvader2
{
    /// <summary>
    /// Missile
    /// </summary>
    public class Missile
    {
        const int MAX_SPEED = 100;

        //position
        private int x;
        private int y;

        //image
        private char sprite = '^';

        private int speed = 100;//vitesse entre 0 et MAX_SPEED

        //État du missile
        private bool destroyed = false;
        public bool Destroyed { get => destroyed; }

        /// <summary>
        /// Construit et affiche le missile
        /// </summary>
        /// <param name="initialX"></param>
        /// <param name="initialY"></param>
        public Missile(int initialX, int initialY)
        {
            this.x = initialX;
            this.y = initialY;

            Console.SetCursorPosition(x, y);
            Console.Write(sprite);
        }

        /// <summary>
        /// Déplacement du missile
        /// </summary>
        /// <param name="tic"></param>
        public void NextMove(int tic)
        {
            if (speed == MAX_SPEED || tic % (MAX_SPEED - speed) == 0)
            {
                //Déplace le missile
                if (y > 0)
                {
                    Console.MoveBufferArea(x, y, 1, 1, x, --y);
                }
                else
                {
                    //efface le missile
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    destroyed = true;
                }
            }
        }


    }
}
