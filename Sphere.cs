using System;

namespace LabWork
{
    public class Sphere : Shape3D
    {
        private double _r;
        public double R => _r;

        public Sphere(double x1, double x2, double x3, double b1, double b2, double b3, double r)
            : base(x1, x2, x3, b1, b2, b3)
        {
            if (r <= 0) throw new ArgumentException("Radius (R) must be positive.");
            this._r = r;
        }


        public Sphere() : this(0, 0, 0, 0, 0, 0, 1) { } 

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * R * R * R;
        }

        public override string ToString()
        {
            double rSquared = R * R;
            return $"({X1} - {B1})^2 + ({X2} - {B2})^2 + ({X3} - {B3})^2 = {rSquared}";
        }

        public override void FillData()
        {
            base.FillData();

            Console.WriteLine("<<< Entering Sphere-Specific Data >>>");
            _r = GetPositiveDoubleInput("Enter R (Radius) >>> ");
        }
    }
}
