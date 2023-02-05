using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.Prototype
{
    internal abstract class Shape
    {
        public abstract float Perimeter { get; }
        public abstract float Area { get; }

        public abstract Point CenterPointOfShape { get; protected set; }

        public abstract Shape Clone();

    }

    internal class Circle : Shape
    {
        float radius;
        public override float Perimeter => (float)(2 * radius * Math.PI);

        public override float Area => (float)(radius * radius * Math.PI);

        public override Point CenterPointOfShape { get; protected set; }

        public Circle()
        {

        }

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public Circle(float radius, int x, int y)
        {
            this.radius = radius;
            this.CenterPointOfShape = new Point(x, y);
        }

        public override Shape Clone()
        {
            Circle c = new Circle(radius);
            c.CenterPointOfShape = new Point(CenterPointOfShape.X, CenterPointOfShape.Y);
            return c;
        }
    }

    internal class Suqare
    {
        float side;
        public Suqare(float side)
        {
            this.side = side;
        }
    }

    internal class Triangle : Shape
    {
        float basis;
        float height;

        public Triangle(float basis, float height)
        {
            this.basis = basis;
            this.height = height;
        }

        public override float Perimeter => throw new NotImplementedException();

        public override float Area => basis * height / 2;

        public override Point CenterPointOfShape { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public override Shape Clone()
        {
            return new Triangle(basis, height);
        }
    }
}
