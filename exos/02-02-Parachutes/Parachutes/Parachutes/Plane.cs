using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Plane
    {
        // Display attributes
        // dimensions of the ASCII representation of the plane
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        // Model attributes
        public int x;
        public int altitude;
        public List<Para> parachutists;

       
        /// Constructor
        
        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }

       
        /// Render
     
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(view[i]);
            }
        }

        
        /// Move the plane
        
        public void update()
        {
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            else
            {
                x++;
            }
        }

    
        /// Take a parachustist on board
       
        /// <param name="para"></param>
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = x;
            parachutist.altitude = this.altitude;
            return parachutist;
        }
    }
}
