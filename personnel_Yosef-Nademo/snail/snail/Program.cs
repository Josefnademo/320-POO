using System;
using System.Threading;

namespace SnailSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;

            Snail snail1 = new Snail(ConsoleColor.Blue);

            while (snail1.IsAlive())
            {
                snail1.Hide();
                snail1.Move(1, 0); // Moves the snail to the right by 1 unit
                snail1.Show();
                Thread.Sleep(100); // Wait for 100 milliseconds
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Class representing a snail
    /// </summary>
    public class Snail
    {
        public string SnailSymbol { get; private set; } = "_@_ö";
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int XP { get; private set; }

        private ConsoleColor _color;

        private const string NO_SNAIL = "    ";
        private const string DEAD_SNAIL = "____";

        /// <summary>
        /// Default constructor
        /// </summary>
        public Snail(ConsoleColor color)
        {
            SnailSymbol = "_@_ö";
            PositionX = 1;
            PositionY = 10; // Default starting position
            XP = 50; // Start with 50 XP
            _color = color;
        }

        /// Tells if the snail is still alive
        /// <returns>True if alive, otherwise false</returns>
        public bool IsAlive()
        {
            return XP > 0;
        }

       
        /// Move the snail
        /// <param name="deltaX">Change in X position</param>
        /// <param name="deltaY">Change in Y position</param>
        public void Move(int deltaX, int deltaY)
        {
            PositionX += deltaX;
            PositionY += deltaY;

            // Decrease XP for each movement
            XP -= 1;

            Console.WriteLine($"Snail is at ({PositionX}, {PositionY}) position. XP left: {XP}");
        }

        /// <summary>
        /// Make the snail disappear
        /// </summary>
        public void Hide()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(NO_SNAIL);
        }

        /// <summary>
        /// Show the snail according to its state
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(PositionX, PositionY);
            if (this.IsAlive())
            {
                Console.Write(SnailSymbol);
            }
            else
            {
                Console.Write(DEAD_SNAIL);
            }
        }
    }
}
