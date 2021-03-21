using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    abstract class DrawingShape
    {
        protected int size;
        protected int locX = 0, locY = 0;
        protected Shape shape = null;

        public DrawingShape(int size)
        {
            this.size = size;
        }
        public void SetLocation(int xCoord, int yCoord)
        {
            locX = xCoord;
            locY = yCoord;
        }
        public void SetColor(Color color)
        {
            if(shape != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.shape.Fill = brush;
            }
        }
        public virtual void Draw(Canvas canvas)
        {
            if(shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            shape.Height = size;
            shape.Width = size;
            Canvas.SetLeft(this.shape, locX);
            Canvas.SetTop(this.shape, locY);
            canvas.Children.Add(shape);
        }


    }
}
