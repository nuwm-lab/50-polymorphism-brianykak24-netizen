using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public class Ellipsoid : Shape3D
    {
        private double _a1, _a2, _a3;
        public double A1 => _a1;
        public double A2 => _a2;
        public double A3 => _a3;

        // Конструктор Ellipsoid не приймає R і викликає лише конструктор Shape3D
        public Ellipsoid(double x1, double x2, double x3, double b1, double b2, double b3, double a1, double a2, double a3)
            : base(x1, x2, x3, b1, b2, b3) // Тільки спільні параметри
        {
            if (a1 <= 0 || a2 <= 0 || a3 <= 0) throw new ArgumentException("All semi-axes (A1, A2, A3) must be positive.");
            this._a1 = a1;
            this._a2 = a2;
            this._a3 = a3;
        }

        // Дефолтний еліпсоїд (сфера з A=1)
        public Ellipsoid() : this(0, 0, 0, 0, 0, 0, 1, 1, 1) { }

        public override double GetVolume()
        {
            // V = (4/3) * pi * a1 * a2 * a3
            return (4.0 / 3.0) * Math.PI * A1 * A2 * A3;
        }

        public override string ToString()
        {
            // (x-b1)^2/a1^2 + (y-b2)^2/a2^2 + (z-b3)^2/a3^2 = 1
            return $"(({X1} - {B1})^2)/({A1}^2) + (({X2} - {B2})^2)/({A2}^2) + (({X3} - {B3})^2)/({A3}^2) = 1";
        }

        public override void FillData()
        {
            base.FillData(); // Викликає ввід X та B

            Console.WriteLine("--- Entering Ellipsoid-Specific Data ---");
            _a1 = GetPositiveDoubleInput("Enter A1 (Semi-axis X) >>> ");
            _a2 = GetPositiveDoubleInput("Enter A2 (Semi-axis Y) >>> ");
            _a3 = GetPositiveDoubleInput("Enter A3 (Semi-axis Z) >>> ");
        }
    }
}
