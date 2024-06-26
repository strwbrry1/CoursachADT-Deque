using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class DrawingDeque
    {
        private State? dequeState;

        private int unitSize;
        private int spaceBetween;
        private int numUnits;

        private int pictureWidth;
        private int pictureHeight;

        public DrawingDeque(int width, int height)
        {
            this.pictureWidth = width;
            this.pictureHeight = height;
        }

        private void DrawUnit(Graphics g, int x, int y, string label)
        {
            Pen pen = new(Color.Black, 3);
            Pen arrowPen = new(Color.Orange, 3);
            Brush brBrush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, x, y, unitSize, unitSize);
            //bottom arrow
            g.DrawLine(arrowPen, x, y + unitSize, x - spaceBetween, y + unitSize);
            g.DrawLine(arrowPen, x - spaceBetween, y + unitSize, x - spaceBetween + 10, y + unitSize - 10);
            g.DrawLine(arrowPen, x - spaceBetween, y + unitSize, x - spaceBetween + 10, y + unitSize + 10);
            //top arrow
            g.DrawLine(arrowPen, x + unitSize, y, x + unitSize + spaceBetween, y);
            g.DrawLine(arrowPen, x + unitSize + spaceBetween, y, x + unitSize + spaceBetween - 10, y - 10);
            g.DrawLine(arrowPen, x + unitSize + spaceBetween, y, x + unitSize + spaceBetween - 10, y + 10);

            Font drawFont = new Font("Arial", 16);
            g.DrawString(label, drawFont, brBrush, x + unitSize / 2 - 5, y + unitSize / 2 - 5);
        }

        public void Visualize(Graphics g, State? state)
        {
            if (state == null) return;
            numUnits = state.numElems;
            unitSize = 80;
            spaceBetween = 30;

            Pen pen = new(Color.Black, 3);
            Brush brBrush = new SolidBrush(Color.Brown);
            Node<int> curr = state.dequeState.getHeadPointer();

            if (curr == null) return;
            for (int i = 0; i < numUnits; i++)
            {

                DrawUnit(g, ((pictureWidth / 2) - unitSize / 2) + (i * (unitSize + spaceBetween)), ((pictureHeight / 2) - unitSize / 2), curr.data.ToString());
                curr = curr.next;
                if (curr == null) break;
            }

        }
    }
}
