using System;

namespace HeCacDoiTuongHinhHoc
{
    public class Circle:Shape
    {
        private double radius = 1.0;
        private double Radius
        { 
            get => radius; set => radius = value;
        }
        public Circle(){}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color,filled)
        {
            this.radius = radius;
        }
        private double GetArea ()
        {
            return radius*radius*3.14;
        }
        private double GetPerimeter ()
        {
            return 2*radius*3.14;
        }
        public override string ToString()
        {
            return "A Circle with radius "+ Radius+ " which is a subclass of " + base.ToString();
        }
    }
}