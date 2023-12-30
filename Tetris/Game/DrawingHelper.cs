using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using static Logic.Build.Blocks.Color;

namespace Game
{
    public class DrawingHelper
    {
        public static Collection<Rectangle> VectorOfRectangles { get; set; }

        private static Dictionary<Shape, (double, double)> ShapesProperties { get; }

        static DrawingHelper()
        {
            VectorOfRectangles = new Collection<Rectangle>();

            ShapesProperties = new Dictionary<Shape, (double, double)>();
        }

        private static void AddShapeProperties(
            Canvas canvas, Shape shape, double leftProperty, double topProperty, double scaleValue)
        {
            canvas.Children.Add(shape);
            ShapesProperties.Add(shape, (leftProperty, topProperty));

            Canvas.SetLeft(shape, leftProperty * scaleValue);
            Canvas.SetTop(shape, topProperty * scaleValue);

            shape.LayoutTransform = new ScaleTransform
            {
                ScaleX = scaleValue,
                ScaleY = scaleValue
            };
        }

        public static void UpdateShapesProperties(
            Canvas canvas, double scaleValue)
        {
            if (canvas != null)
            {
                foreach (Shape shape in ShapesProperties.Keys)
                {
                    Canvas.SetLeft(shape, ShapesProperties[shape].Item1 * scaleValue);
                    Canvas.SetTop(shape, ShapesProperties[shape].Item2 * scaleValue);

                    (shape.LayoutTransform as ScaleTransform).ScaleX = scaleValue;
                    (shape.LayoutTransform as ScaleTransform).ScaleY = scaleValue;
                }
            }
        }

        public static Rectangle DrawRectangle(
            Canvas canvas, Point leftTop, Point rightBottom, int thickness, Logic.Build.Blocks.Color color, double scaleValue)
        {
            Rectangle rectangle = new Rectangle
            {
                Stroke = Brushes.DarkGray,
                Fill = GetBrushColor(color),
                StrokeThickness = thickness,
                Width = Math.Abs(rightBottom.X - leftTop.X),
                Height = Math.Abs(rightBottom.Y - leftTop.Y)
            };

            VectorOfRectangles.Add(rectangle);
            AddShapeProperties(canvas, rectangle, leftTop.X, leftTop.Y, scaleValue);

            return rectangle;
        }

        public static bool RemoveUiElement(Canvas canvas, UIElement element)
        {
            if (element != null)
            {
                canvas.Children.Remove(element);
                ShapesProperties.Remove(element as Shape);

                if (element is Rectangle rectangle)
                    return VectorOfRectangles.Remove(rectangle);
            }

            return false;
        }

        public static void RemoveUiElements<TElement>(Canvas canvas)
            where TElement : UIElement
        {
            var items = canvas.Children.OfType<TElement>().ToList();
            items.RemoveAll(item =>
            {
                return RemoveUiElement(canvas, item);
            });
        }

        public static void RemoveUiElements(Canvas canvas)
        {
            RemoveUiElements<Line>(canvas);
            RemoveUiElements<Rectangle>(canvas);
            RemoveUiElements<Ellipse>(canvas);
            RemoveUiElements<Polygon>(canvas);
        }

        public static Brush GetBrushColor(Logic.Build.Blocks.Color color)
        {
            switch (color)
            {
                case White: return Brushes.White;
                case Light_Blue: return Brushes.LightBlue;
                case Blue: return Brushes.Blue;
                case Orange: return Brushes.Orange;
                case Yellow: return Brushes.Yellow;
                case Green: return Brushes.Green;
                case Magenta: return Brushes.Magenta;
                case Red: return Brushes.Red;
                default: throw new Exception("e grav");
            }
        }
    }
}
