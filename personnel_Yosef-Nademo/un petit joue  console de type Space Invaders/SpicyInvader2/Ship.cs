//Auteur : JMY
//Date   : 21.1.2020 
//Lieu   : ETML
//Descr. : Vaisseau
using System;

namespace SpicyInvader2
{
    /// <summary>
    /// Vaisseau
    /// </summary>
    class Ship
    {
        //position du vaisseau
        private int x;
        private int y;

        //Dessin du vaisseau
        private char sprite;

        //missile du vaisseau
        private Missile missile;

        /// <summary>
        /// Construit un vaisseau
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="initialX"></param>
        /// <param name="initialY"></param>
        public Ship(char sprite, int initialX, int initialY)
        {
            this.sprite = sprite;
            this.x = initialX;
            this.y = initialY;
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
            int newX = x; //nouvelle coordonnées

            //Mouvement du vaisseau géré par l'utilisateur avec gestion de l'appui long sur une touche (nativekeyboard)
            if (Console.KeyAvailable)
            {
                //GAUCHE
                if (NativeKeyboard.IsKeyDown(KeyCode.Left))
                {
                    if (x > 0)
                    {
                        newX--;
                    }
                }
                //DROITE
                else if (NativeKeyboard.IsKeyDown(KeyCode.Right))
                {
                    if (x < Console.WindowWidth)
                    {
                        newX++;
                    }
                }
                //BARRE ESPACE
                else if(NativeKeyboard.IsKeyDown(KeyCode.Spacebar))
                {
                    if (!IsMissileFired())
                    {
                        missile = new Missile(x, y - 1);
                    }
                }

                //Le vaisseau s'est-il déplacé ?
                if (newX != x)
                {
                    //Déplace efficacement le vaisseau
                    Console.MoveBufferArea(x, y, 1, 1, newX, y);

                    //Mise à jour de la nouvelle position
                    x = newX;
                }
            }

            //Mouvement autonome du missile s'il y en a
            if (IsMissileFired())
            {
                //Le missile est-il arrivé en haut ?
                if (missile.Destroyed)
                {
                    missile = null;
                }
                else
                {
                    missile.NextMove(tic);//déplacement du missile
                }
            }

        }

        /// <summary>
        /// Indique si un missile est en cours
        /// </summary>
        /// <returns></returns>
        private bool IsMissileFired()
        {
            return missile != null;
        }
    }
}
