using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursachADT_Deque
{
    public class DrawingDeque
    {
        private State dequeState;

        private int unitSize;
        private int spaceBetween;

        public DrawingDeque(State state) 
        { 
            this.dequeState = state;
        }

        public void Visualize(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            Brush brBrush = new SolidBrush(Color.Brown);

            g.DrawRectangle(pen, 10, 10, 100, 100);
        }
    }
}
