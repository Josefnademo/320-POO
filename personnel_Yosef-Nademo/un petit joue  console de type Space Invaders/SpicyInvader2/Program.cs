//Auteur : JMY
//Date   : 21.1.2020 
//Lieu   : ETML
//Descr. : Spicy invader2
using System;
using System.Diagnostics;
using System.Threading;

namespace SpicyInvader2
{
    /// <summary>
    /// Spicy Invader
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Prépare la console
            Console.WindowWidth = 50;
            Console.WindowHeight = 30;

            //pour régler les FPS
            int FPS_X = Console.WindowWidth - 10;
            int FPS_Y = 0;
            const float FPS = 30.0f;
            const float MS_PER_FRAME = 1000 / FPS;
            float delay;
            int tic = 0;
            double realFps;

            //Création des objets
            Ship ship = new Ship('X', Console.WindowWidth / 2, 25);
            Enemy enemy1 = new Enemy('E', Console.WindowWidth / 2, 5);

            //Affichage initial des objets
            ship.Init();
            enemy1.Init();

            //Pour régler les FPS
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //boucle de jeu
            while (true)
            {
                tic++; //FRAME


                //Gère le déplacement + tir du vaisseau
                ship.NextMove(tic);

                //Gère le déplacement + tir de l'enemi
                enemy1.NextMove(tic);

                //Calcl et affichage FPS
                realFps = Convert.ToDouble(tic) / sw.Elapsed.TotalSeconds;
                Console.SetCursorPosition(FPS_X, FPS_Y);
                Console.WriteLine("FPS: {0,-10:#.00}", realFps);


                //Délai éventuel pour ajuster les FPS
                delay = tic * MS_PER_FRAME - sw.ElapsedMilliseconds;
                if (delay > 0)
                {
                    //Reset pour éviter un overflow
                    if (tic > int.MaxValue - 1)
                    {
                        tic = 0;
                        sw.Restart();
                    }
                    Thread.Sleep(Convert.ToInt32(delay));//Ajustement au FPS

                }
            }
        }
    }
}
