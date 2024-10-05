//Auteur : JMY
//Date   : 21.1.2020 
//Lieu   : ETML
//Descr. : Ennemi
using System;

namespace SpicyInvader2
{
    /// <summary>
    /// Ennemi
    /// </summary>
    class Enemy
    {
        const int MARGIN_LEFT = 10;
        const int MARGIN_RIGHT = 10;

        private char sprite;
        private int x;
        private int y;
        private bool directionRight = true;

        private int speed = 95;//Vitesse entre 0 et 100

        /// <summary>
        /// Construit un objet ennemi
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Enemy(char sprite, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.sprite = sprite;
        }

        /// <summary>
        /// Initialise le vaisseau (le dessine à l'écran)
        /// </summary>
        public void Init()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sprite);
        }

        /// <summary>
        /// Gère le mouvement+tir
        /// </summary>
        public void NextMove(int tic)
        {
            //Éxécute l'action selon la vitesse
            if(tic%(100-speed)==0)
            {
                int newX = x;
                int newY = y;

                if (directionRight)
                {
                    newX = newX + 1;// speed/10;
                }
                else
                {
                    newX = newX - 1;// speed/10;
                }

                //Descend d'une ligne s'il touche le bord
                if (newX > Console.WindowWidth - MARGIN_RIGHT || newX <= MARGIN_LEFT)
                {
                    directionRight = !directionRight;//inverse la direction
                    newY++;//descend verticalement

                }

                //Déplace efficacement le vaisseau
                Console.MoveBufferArea(x, y, 1, 1, newX, newY);

                //Mise à jour de la nouvelle position
                x = newX;
                y = newY;
            }

        }

    }
}
