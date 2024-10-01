using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Para
    {
        // View attributes
        private const int PARA_HEIGHT = 6;

        private string[] viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        // Model attributes

        public string name;
        public int x;
        public int altitude;
        public bool parachuteIsOpen;


        /// Constructor
   
        /// <param name="name"></param>
        public Para(string name)
        {
            this.name = name;
        }

    
        /// Make the parachutist move
    
        internal void update()
        {
            if (altitude > PARA_HEIGHT) // il est en l'air
            {
                if (parachuteIsOpen)
                {
                    altitude -= 1; // il tombe lentement
                }
                else
                {
                    altitude -= 3; // il tombe vite
                }
                // Décision d'ouvrir le parachute
                if (altitude < Config.SCREEN_HEIGHT / 2)
                {
                    parachuteIsOpen = true;
                }
            }
            else // il est au sol
            {
                parachuteIsOpen = false;
            }
        }

        public void draw()
        {
            string[] view = parachuteIsOpen ? viewWithParachute : viewNoParachute;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude + i);
                Console.Write(view[i]);
            }
            Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude -1);
            Console.Write(this.name);
        }

    }
}
