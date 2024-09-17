using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Drone
    {
        public Pen droneBrush = new Pen(new SolidBrush(Color.Red), 15);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {

            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - -15, y - 150 - -300, 50, 70));
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 10, y - 50 - -300, 100, 25));
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - -87, y - 15 - -300, 6, 1));
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 15, y -15 - -300, 6, 1));
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 1, y - 1 - -300, 80,1));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 0, y - -315);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{name} ({((int)((double)charge / 1000 * 100)).ToString()}%)";
        }

    }

}
